using System;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Reflection;
using log4net;
using Newtonsoft.Json;
using RazorLight;
using RazorLight.Razor;

namespace Jdv.Razor
{
	public class RazorTemplateEngine : ITemplateEngine
	{
		private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
		private readonly RazorLightEngine engine;

		public RazorTemplateEngine()
		{
			engine = new RazorLightEngineBuilder()
				.UseProject(new EmbeddedRazorProject(Assembly.GetExecutingAssembly()))
				.UseMemoryCachingProvider()
				.Build();
		}

		#region Implementation of ITemplateEngine

		public void Convert(dynamic data, Stream template, TextWriter stringWriter)
		{
			string readToEnd = template.ReadToString();
			try
			{
				stringWriter.Write(Convert(data, readToEnd));
				stringWriter.Flush();
			}
			catch (Exception e)
			{
				_log.ErrorFormat("Invalid JSON for STREAM template: \n{0}", readToEnd);
				_log.DebugFormat("Invalid JSON for STREAM template: {0}\n\n{1}", JsonConvert.SerializeObject(data), readToEnd);
				throw new RazorParsingException(e.Message);
			}
		}

		public string Convert(dynamic data, string templateData)
		{
			return Convert(data, templateData, true);
		}
		public string Convert(dynamic data, string templateData, bool ifErrorTrySerializeAndDeserialize)
		{
			try
			{
				if (templateData == null || data == null)
					return string.Empty;
				if (!templateData.Contains("#pragma warning disable"))
					//templateData = $"@{{#pragma warning disable}}\n@using System;@using System.Linq;@using System.Collections.Generic;@using IIAB.Core.Helpers\n{templateData}";
					templateData = $"@{{#pragma warning disable}}\n@using System;@using System.Linq;@using System.Collections.Generic\n{templateData}";
				if (RazorConfigSettings.RazorViolationStrings.Any(templateData.Contains))
					throw new RazorViolationException($"Invalid assembly reference");

				var result = engine.CompileRenderStringAsync(GetTemplateCachedId(templateData), templateData, data, (ExpandoObject)null).Result;

				_log.Debug($"RAZOR:\n{result}");

				return result;
			}
			catch (RazorViolationException re)
			{
				_log.Error($"Invalid assembly reference: \n{templateData}", re);
				_log.Debug($"Invalid assembly reference: {JsonConvert.SerializeObject(data)}\n\n{templateData}", re);
				throw;
			}
			catch (Exception e)
			{
				//TODO: Jdv See if netcore 3 version has this fixed
				if (ifErrorTrySerializeAndDeserialize && e.Message.Contains("definition")) // Workaround for missing member errors in razor 
				{
					try
					{
						var dataUnboxed = JsonConvert.DeserializeObject<dynamic>(JsonConvert.SerializeObject(data));
						return Convert(dataUnboxed, templateData, false);
					}
					catch (JsonSerializationException jsonEx)
					{
						if (jsonEx.Message.Contains("ManifestModule"))
						{
							_logParseError(data, templateData, e, false);
							throw new RazorParsingException(e.Message);
						}
						_logParseError(data, templateData, jsonEx, false);
						throw new RazorParsingException(jsonEx.Message);
					}
					catch (Exception innerException)
					{
						_logParseError(data, templateData, innerException);
						throw new RazorParsingException(innerException.Message);
					}
				}
				_logParseError(data, templateData, e);
				throw new RazorParsingException(e.Message);
			}
		}

		private static void _logParseError(dynamic data, string templateData, Exception e, bool logData = true)
		{
			_log.Error($"Invalid JSON for STRING template: {e.Message} \n{templateData}", e);
			if (logData)
			{
				try
				{
					_log.Debug(
						data.Sequence?.Data != null
							? $"Invalid JSON for STRING template: {JsonConvert.SerializeObject(data.Sequence.Data)}\n\n{templateData}"
							: $"Invalid JSON for STRING template: {JsonConvert.SerializeObject(data)}\n\n{templateData}", e);
				}
				// ReSharper disable once EmptyGeneralCatchClause
				catch { }
			}
		}

		#endregion

		#region Private Methods
		private string GetTemplateCachedId(string templateData)
		{
			return "CH" + templateData.GetHashCode();
		}
		#endregion
	}
}