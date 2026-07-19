using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(207)]
	public struct GSGameplayStats_t
	{
		public const int k_iCallback = 207;

		public EResult m_eResult;

		public int m_nRank;

		public uint m_unTotalConnects;

		public uint m_unTotalMinutesPlayed;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamPartyBeaconLocation_t
	{
		public ESteamPartyBeaconLocationType m_eType;

		public ulong m_ulLocationID;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1252)]
	public struct SteamNetworkingMessagesSessionFailed_t
	{
		public const int k_iCallback = 1252;

		public SteamNetConnectionInfo_t m_info;
	}
}
