using System.Runtime.InteropServices;

namespace GorillaTagScripts.GhostReactor
{
}
namespace GorillaTagScripts.UI.ModIO
{
}
namespace Viveport.Internal
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void StatusCallback2(int nResult, [MarshalAs(UnmanagedType.LPStr)] string message);
}
