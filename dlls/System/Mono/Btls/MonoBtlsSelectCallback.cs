using System.Runtime.InteropServices;

namespace System.CodeDom
{
}
namespace Mono.Btls
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate int MonoBtlsSelectCallback(string[] acceptableIssuers);
}
