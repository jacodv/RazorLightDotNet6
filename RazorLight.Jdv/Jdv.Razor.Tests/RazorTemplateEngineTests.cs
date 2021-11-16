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

			// assert
			result .Should().Be("Name is TheName");
		}
	}
}