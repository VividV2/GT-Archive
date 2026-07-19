using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum EGCResults
	{
		k_EGCResultOK,
		k_EGCResultNoMessage,
		k_EGCResultBufferTooSmall,
		k_EGCResultNotLoggedOn,
		k_EGCResultInvalidMessage
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(345)]
	public struct FriendsIsFollowing_t
	{
		public const int k_iCallback = 345;

		public EResult m_eResult;

		public CSteamID m_steamID;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIsFollowing;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(503)]
	public struct LobbyInvite_t
	{
		public const int k_iCallback = 503;

		public ulong m_ulSteamIDUser;

		public ulong m_ulSteamIDLobby;

		public ulong m_ulGameID;
	}
}
