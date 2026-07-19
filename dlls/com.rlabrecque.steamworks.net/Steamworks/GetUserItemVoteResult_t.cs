using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum ESteamNetworkingIdentityType
	{
		k_ESteamNetworkingIdentityType_Invalid = 0,
		k_ESteamNetworkingIdentityType_SteamID = 16,
		k_ESteamNetworkingIdentityType_XboxPairwiseID = 17,
		k_ESteamNetworkingIdentityType_SonyPSN = 18,
		k_ESteamNetworkingIdentityType_GoogleStadia = 19,
		k_ESteamNetworkingIdentityType_IPAddress = 1,
		k_ESteamNetworkingIdentityType_GenericString = 2,
		k_ESteamNetworkingIdentityType_GenericBytes = 3,
		k_ESteamNetworkingIdentityType_UnknownType = 4,
		k_ESteamNetworkingIdentityType__Force32bit = int.MaxValue
	}
}
namespace Steamworks
{
	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1111)]
	public struct LeaderboardUGCSet_t
	{
		public const int k_iCallback = 1111;

		public EResult m_eResult;

		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
}
namespace Steamworks
{
	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3409)]
	public struct GetUserItemVoteResult_t
	{
		public const int k_iCallback = 3409;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;

		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
		public bool m_bVotedUp;

		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
		public bool m_bVotedDown;

		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
		public bool m_bVoteSkipped;
	}
}
namespace Steamworks
{
	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4103)]
	public struct MusicPlayerRemoteToFront_t
	{
		public const int k_iCallback = 4103;
	}
}
namespace Steamworks
{
	public enum ERemoteStorageLocalFileChange
	{
		k_ERemoteStorageLocalFileChange_Invalid,
		k_ERemoteStorageLocalFileChange_FileUpdated,
		k_ERemoteStorageLocalFileChange_FileDeleted
	}
}
