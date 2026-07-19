using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4508)]
	public struct HTML_ChangedTitle_t
	{
		public const int k_iCallback = 4508;

		public HHTMLBrowser unBrowserHandle;

		public string pchTitle;
	}
}
namespace Steamworks
{
	public enum EP2PSend
	{
		k_EP2PSendUnreliable,
		k_EP2PSendUnreliableNoDelay,
		k_EP2PSendReliable,
		k_EP2PSendReliableWithBuffering
	}
}
namespace Steamworks
{
	public enum EGameSearchErrorCode_t
	{
		k_EGameSearchErrorCode_OK = 1,
		k_EGameSearchErrorCode_Failed_Search_Already_In_Progress,
		k_EGameSearchErrorCode_Failed_No_Search_In_Progress,
		k_EGameSearchErrorCode_Failed_Not_Lobby_Leader,
		k_EGameSearchErrorCode_Failed_No_Host_Available,
		k_EGameSearchErrorCode_Failed_Search_Params_Invalid,
		k_EGameSearchErrorCode_Failed_Offline,
		k_EGameSearchErrorCode_Failed_NotAuthorized,
		k_EGameSearchErrorCode_Failed_Unknown_Error
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1314)]
	public struct RemoteStorageEnumerateUserSubscribedFilesResult_t
	{
		public const int k_iCallback = 1314;

		public EResult m_eResult;

		public int m_nResultsReturned;

		public int m_nTotalResultCount;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public PublishedFileId_t[] m_rgPublishedFileId;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 50)]
		public uint[] m_rgRTimeSubscribed;
	}
}
