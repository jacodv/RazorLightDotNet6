using System.IO;

namespace Jdv.Razor
{
	public static class Helpers
	{
		public static string ReadToString(this Stream stream)
		{
			if (stream == null) return null;
			var streamReader = new StreamReader(stream);
			var readToString = streamReader.ReadToEnd();
			return readToString;
		}
	}
}