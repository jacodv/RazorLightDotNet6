using System.Threading.Tasks;
using FluentAssertions;
using NUnit.Framework;

namespace Jdv.Razor.Web.Tests
{
	[TestFixture]
  public class ControllerTests
  {

	  private void Setup()
	  {

	  }

	  [Test]
	  public async Task Convert_GivenValidController_ShouldConvertItem()
	  {
		  // arrange
		  Setup();
		  var expected = "ThePropValue";
		  var _templateEngine = new RazorTemplateEngine();
		  var template = "@Model.SomeClass.SomeProp";
		  var data = new { SomeClass = new { SomeProp = expected } };

		  // action
		  var result = _templateEngine.Convert(data, template);

		  // assert
		  result.Should().Be(expected);
	  }

  }
}