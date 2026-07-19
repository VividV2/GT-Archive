using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(739)]
	public struct FilterTextDictionaryChanged_t
	{
		public const int k_iCallback = 739;

		public int m_eLanguage;
	}
}
namespace Steamworks
{
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(703)]
	public struct SteamAPICallCompleted_t
	{
		public const int k_iCallback = 703;

		public SteamAPICall_t m_hAsyncCall;

		public int m_iCallback;

		public uint m_cubParam;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(342)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		public const int k_iCallback = 342;

		public CSteamID m_steamIDClanChat;

		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(168)]
	public struct GetTicketForWebApiResponse_t
	{
		public const int k_iCallback = 168;

		public HAuthTicket m_hAuthTicket;

		public EResult m_eResult;

		public int m_cubTicket;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 2560)]
		public byte[] m_rgubTicket;
	}
}
namespace Steamworks
{
	public enum ESteamInputLEDFlag
	{
		k_ESteamInputLEDFlag_SetColor,
		k_ESteamInputLEDFlag_RestoreUserDefault
	}
}
