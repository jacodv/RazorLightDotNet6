using System;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace Jdv.Razor.Tests
{
	public class RazorTemplateEngineTests
	{
		private RazorTemplateEngine _engine;

		[SetUp]
		public void Setup()
		{
			_engine = new RazorTemplateEngine();
		}

		[Test]
		public void Constructor_GivenValidInput_ShouldCreateInstance()
		{
			//Setup
			Setup();
			_engine.Should().NotBeNull();
		}

		[Test]
		public void Convert_GivenValidInput_ShouldConvert()
		{
			// arrange
			Setup();
			var data = new { Name = "TheName" };
			var template = "Name is @Model.Name";

			// action
			var result = _engine.Convert(data, template, true);

//			var signedResult = _sign(Encoding.UTF8.GetBytes(result), X509Certificate2.CreateFromPemFile("personal.pem"));

			// assert
			result.Should().Be("Name is TheName");
		}

		private static byte[] _sign(byte[] message, X509Certificate2 cert)
		{
			var contentInfo = new ContentInfo(message);
			var signedCms = new SignedCms(contentInfo);
			var cmsSigner = new CmsSigner(cert)
			{
				IncludeOption = X509IncludeOption.EndCertOnly
			};

			signedCms.ComputeSignature(cmsSigner);

			var signed = signedCms.Encode();
			return signed;
		}
	}

}