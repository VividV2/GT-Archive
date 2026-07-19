using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(2302)]
	public struct ScreenshotRequested_t
	{
		public const int k_iCallback = 2302;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[CallbackIdentity(340)]
	public struct GameConnectedChatLeave_t
	{
		public const int k_iCallback = 340;

		public CSteamID m_steamIDClanChat;

		public CSteamID m_steamIDUser;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bKicked;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bDropped;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(152)]
	public struct MicroTxnAuthorizationResponse_t
	{
		public const int k_iCallback = 152;

		public uint m_unAppID;

		public ulong m_ulOrderID;

		public byte m_bAuthorized;
	}
}
