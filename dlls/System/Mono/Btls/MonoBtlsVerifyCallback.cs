using System.Runtime.InteropServices;

namespace System.ComponentModel
{
}
namespace Mono.Btls
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int MonoBtlsVerifyCallback(MonoBtlsX509StoreCtx ctx);
}
