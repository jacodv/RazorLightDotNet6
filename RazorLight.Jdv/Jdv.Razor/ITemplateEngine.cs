using System.IO;

namespace Jdv.Razor
{
	public interface ITemplateEngine
   {
	   void Convert(dynamic data, Stream template, TextWriter stringWriter);
	   string Convert(dynamic data, string templateData);
   }
}
