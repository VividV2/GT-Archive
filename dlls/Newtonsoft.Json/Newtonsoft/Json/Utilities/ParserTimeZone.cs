using System.Runtime.Serialization;

namespace Newtonsoft.Json.Utilities
{
	internal enum ParserTimeZone
	{
		Unspecified,
		Utc,
		LocalWestOfUtc,
		LocalEastOfUtc
	}
}
namespace Newtonsoft.Json.Serialization
{
	public delegate void SerializationCallback(object o, StreamingContext context);
}
