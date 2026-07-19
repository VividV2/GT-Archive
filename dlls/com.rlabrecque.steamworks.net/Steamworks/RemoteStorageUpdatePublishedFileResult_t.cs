using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1316)]
	public struct RemoteStorageUpdatePublishedFileResult_t
	{
		public const int k_iCallback = 1316;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(504)]
	public struct LobbyEnter_t
	{
		public const int k_iCallback = 504;

		public ulong m_ulSteamIDLobby;

		public uint m_rgfChatPermissions;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bLocked;

		public uint m_EChatRoomEnterResponse;
	}
}
namespace Steamworks
{
	public enum ESteamIPv6ConnectivityProtocol
	{
		k_ESteamIPv6ConnectivityProtocol_Invalid,
		k_ESteamIPv6ConnectivityProtocol_HTTP,
		k_ESteamIPv6ConnectivityProtocol_UDP
	}
}
