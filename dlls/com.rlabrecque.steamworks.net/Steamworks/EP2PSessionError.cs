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
