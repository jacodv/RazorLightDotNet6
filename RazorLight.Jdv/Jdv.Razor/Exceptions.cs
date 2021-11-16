using System;
using System.Runtime.Serialization;

namespace Jdv.Razor
{
	[Serializable]
	public class RazorParsingException : Exception
	{
		public RazorParsingException()
		{
		}
		public RazorParsingException(string message) : base(message)
		{
		}
		public RazorParsingException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
		}

		public RazorParsingException(string message, Exception innerException) : base(message, innerException)
		{
		}
	}

	public class RazorViolationException : Exception
	{
		public RazorViolationException()
		{
		}

		public RazorViolationException(string message) : base(message)
		{
		}
	}
}