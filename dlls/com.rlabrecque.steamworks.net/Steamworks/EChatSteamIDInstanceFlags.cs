using System;
using System.Runtime.InteropServices;
using System;

namespace Steamworks
{
	[Flags]
	public enum EChatSteamIDInstanceFlags
	{
		k_EChatAccountInstanceMask = 0xFFF,
		k_EChatInstanceFlagClan = 0x80000,
		k_EChatInstanceFlagLobby = 0x40000,
		k_EChatInstanceFlagMMSLobby = 0x20000
	}
}
namespace Steamworks
{
	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(341)]
	public struct DownloadClanActivityCountsResult_t
	{
		public const int k_iCallback = 341;

		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
		public bool m_bSuccess;
	}
}
