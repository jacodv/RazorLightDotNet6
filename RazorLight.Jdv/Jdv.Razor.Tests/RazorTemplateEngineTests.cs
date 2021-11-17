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

			var signedResult = Sign(Encoding.UTF8.GetBytes(result), X509Certificate2.CreateFromPemFile("personal.pem"));

			// assert
			result.Should().Be("Name is TheName");
		}

		public static byte[] Sign(byte[] message, X509Certificate2 cert)
	{
		byte[] signed;

		try
		{
			// Se pone el Mensaje recibido en un objeto ContentInfo                 
			ContentInfo infoContenidoMsj = new ContentInfo(message);
			// Se instancia el CMS Firmado con el ContentInfo
			SignedCms cmsFirmado = new SignedCms(infoContenidoMsj);
			// Se instancia el objeto CmsSigner con las caracteristicas del firmante 
			CmsSigner cmsFirmante = new CmsSigner(cert);

			cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly;

			// Se firma el mensaje PKCS #7 con el certificado
			cmsFirmado.ComputeSignature(cmsFirmante);

			signed = cmsFirmado.Encode();

			// Retorno el mensaje PKCS #7 firmado . 
			return signed;
		}
		catch (Exception excepcionAlFirmar)
		{
			throw new Exception(
				"ERROR: Procedimiento: FirmarMensaje. Al intentar firmar el mensaje con el certificado del firmante: " +
				excepcionAlFirmar.Message);
		}
	}
}

}