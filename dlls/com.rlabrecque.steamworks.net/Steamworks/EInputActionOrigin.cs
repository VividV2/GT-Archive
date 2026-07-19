using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks;

public enum ESteamInputGlyphSize
{
	k_ESteamInputGlyphSize_Small,
	k_ESteamInputGlyphSize_Medium,
	k_ESteamInputGlyphSize_Large,
	k_ESteamInputGlyphSize_Count
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
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1327)]
	public struct RemoteStorageSetUserPublishedFileActionResult_t
	{
		public const int k_iCallback = 1327;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public EWorkshopFileAction m_eAction;
	}
}
