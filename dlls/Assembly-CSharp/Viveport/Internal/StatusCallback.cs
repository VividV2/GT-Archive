using System.Runtime.InteropServices;

namespace Utilities
{
}
namespace Viveport.Internal
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void StatusCallback(int nResult);
}
