using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Viveport.Internal
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void IAPurchaseCallback(int code, [MarshalAs(UnmanagedType.LPStr)] string message);
}
namespace Viveport.Internal
{
	internal enum ESubscriptionTransactionType
	{
		UNKNOWN,
		PAID,
		REDEEM,
		FREEE_TRIAL
	}
}
