using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace System
{
	internal struct ConsoleScreenBufferInfo
	{
		public Coord Size;

		public Coord CursorPosition;

		public short Attribute;

		public SmallRect Window;

		public Coord MaxWindowSize;
	}
}
namespace Mono
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	internal struct ValueTuple
	{
	}
}
namespace System.Runtime.Serialization.Formatters.Binary
{
}
