using System.Security;
using System.Security;

namespace System.Globalization
{
	internal struct InternalEncodingDataItem
	{
		[SecurityCritical]
		internal string webName;

		internal ushort codePage;
	}
}
namespace System.IO
{
	[Flags]
	public enum FileShare
	{
		None = 0,
		Read = 1,
		Write = 2,
		ReadWrite = 3,
		Delete = 4,
		Inheritable = 0x10
	}
}
