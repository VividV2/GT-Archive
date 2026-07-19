using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum EDurationControlNotification
	{
		k_EDurationControlNotification_None,
		k_EDurationControlNotification_1Hour,
		k_EDurationControlNotification_3Hours,
		k_EDurationControlNotification_HalfProgress,
		k_EDurationControlNotification_NoProgress,
		k_EDurationControlNotification_ExitSoon_3h,
		k_EDurationControlNotification_ExitSoon_5h,
		k_EDurationControlNotification_ExitSoon_Night
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamParamStringArray_t
	{
		public IntPtr m_ppStrings;

		public int m_nNumStrings;
	}
}
