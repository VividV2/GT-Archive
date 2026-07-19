using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Viveport.Internal
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void IAPurchaseCallback(int code, [MarshalAs(UnmanagedType.LPStr)] string message);
}
namespace GorillaTag.Cosmetics
{
}
