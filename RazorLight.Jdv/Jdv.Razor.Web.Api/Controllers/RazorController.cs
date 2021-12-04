using Microsoft.AspNetCore.Mvc;

namespace Jdv.Razor.Web.Api.Controllers;

[ApiController]
[Route("/api/razor")]
public class RazorController : ControllerBase
{
	private readonly ILogger<RazorController> _logger;
	private readonly RazorTemplateEngine _templateEngine;

	public RazorController(ILogger<RazorController> logger)
	{
		_logger = logger;
		_templateEngine = new RazorTemplateEngine();
	}

	[HttpGet(Name = "GetRazor")]
	public string Get()
	{
		var expected = "ThePropValue";
		var template = "@Model.SomeClass.SomeProp";
		var data = new { SomeClass = new { SomeProp = expected } };

		return _templateEngine.Convert(data, template);

	}
}