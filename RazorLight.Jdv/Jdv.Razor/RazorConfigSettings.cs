
namespace Jdv.Razor
{
	public static class RazorConfigSettings
	{
		public static string[] RazorViolationStrings => new []
		{
			"System.Environment", 
			"System.Reflection",
			"System.Diagnostics",
			"System.Net",
			"System.Http"
		};
	}}