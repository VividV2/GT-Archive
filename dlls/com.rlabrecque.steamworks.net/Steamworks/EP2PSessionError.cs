using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
}
namespace Steamworks
{
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4704)]
	public struct SteamInventoryStartPurchaseResult_t
	{
		public const int k_iCallback = 4704;

		public EResult m_result;

		public ulong m_ulOrderID;

		public ulong m_ulTransID;
	}
}
namespace Steamworks
{
}
namespace Steamworks
{
}
namespace Steamworks
{
	public enum EActivateGameOverlayToWebPageMode
	{
		k_EActivateGameOverlayToWebPageMode_Default,
		k_EActivateGameOverlayToWebPageMode_Modal
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1102)]
	public struct UserStatsStored_t
	{
		public const int k_iCallback = 1102;

		public ulong m_nGameID;

		public EResult m_eResult;
	}
}
namespace Steamworks
{
}
namespace Steamworks
{
	public enum EP2PSessionError
	{
		k_EP2PSessionErrorNone = 0,
		k_EP2PSessionErrorNoRightsToApp = 2,
		k_EP2PSessionErrorTimeout = 4,
		k_EP2PSessionErrorNotRunningApp_DELETED = 1,
		k_EP2PSessionErrorDestinationNotLoggedIn_DELETED = 3,
		k_EP2PSessionErrorMax = 5
	}
}
namespace Steamworks
{
	[Flags]
	public enum EBetaBranchFlags
	{
		k_EBetaBranch_None = 0,
		k_EBetaBranch_Default = 1,
		k_EBetaBranch_Available = 2,
		k_EBetaBranch_Private = 4,
		k_EBetaBranch_Selected = 8,
		k_EBetaBranch_Installed = 0x10
	}
}
namespace Steamworks
{
	public enum ELeaderboardDataRequest
	{
		k_ELeaderboardDataRequestGlobal,
		k_ELeaderboardDataRequestGlobalAroundUser,
		k_ELeaderboardDataRequestFriends,
		k_ELeaderboardDataRequestUsers
	}
}
namespace Steamworks
{
}
namespace Steamworks
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(344)]
	public struct FriendsGetFollowerCount_t
	{
		public const int k_iCallback = 344;

		public EResult m_eResult;

		public CSteamID m_steamID;

		public int m_nCount;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4507)]
	public struct HTML_OpenLinkInNewTab_t
	{
		public const int k_iCallback = 4507;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;
	}
}
namespace Steamworks
{
}
namespace Steamworks
{
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1313)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		public const int k_iCallback = 1313;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
}
