using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices.WindowsRuntime
{
}
namespace System
{
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class Pinnable<T>
	{
		public T Data;
	}
}
