using System;
using System;

namespace Valve.Newtonsoft.Json.Bson
{
	internal enum BsonBinaryType : byte
	{
		Binary = 0,
		Function = 1,
		[Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")]
		BinaryOld = 2,
		[Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")]
		UuidOld = 3,
		Uuid = 4,
		Md5 = 5,
		UserDefined = 128
	}
}
namespace Valve.Newtonsoft.Json
{
	[Flags]
	public enum DefaultValueHandling
	{
		Include = 0,
		Ignore = 1,
		Populate = 2,
		IgnoreAndPopulate = 3
	}
}
namespace Valve.Newtonsoft.Json
{
	public enum DateParseHandling
	{
		None,
		DateTime,
		DateTimeOffset
	}
}
