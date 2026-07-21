namespace Steamworks
{
	public enum EUserUGCList
	{
		k_EUserUGCList_Published,
		k_EUserUGCList_VotedOn,
		k_EUserUGCList_VotedUp,
		k_EUserUGCList_VotedDown,
		k_EUserUGCList_WillVoteLater,
		k_EUserUGCList_Favorited,
		k_EUserUGCList_Subscribed,
		k_EUserUGCList_UsedOrPlayed,
		k_EUserUGCList_Followed
	}
}
namespace Steamworks
{
	public enum EAuthSessionResponse
	{
		k_EAuthSessionResponseOK,
		k_EAuthSessionResponseUserNotConnectedToSteam,
		k_EAuthSessionResponseNoLicenseOrExpired,
		k_EAuthSessionResponseVACBanned,
		k_EAuthSessionResponseLoggedInElseWhere,
		k_EAuthSessionResponseVACCheckTimedOut,
		k_EAuthSessionResponseAuthTicketCanceled,
		k_EAuthSessionResponseAuthTicketInvalidAlreadyUsed,
		k_EAuthSessionResponseAuthTicketInvalid,
		k_EAuthSessionResponsePublisherIssuedBan,
		k_EAuthSessionResponseAuthTicketNetworkIdentityFailure
	}
}
