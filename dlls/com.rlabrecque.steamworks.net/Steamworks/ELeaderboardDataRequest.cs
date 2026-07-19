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
	public enum ESteamNetworkingSocketsDebugOutputType
	{
		k_ESteamNetworkingSocketsDebugOutputType_None = 0,
		k_ESteamNetworkingSocketsDebugOutputType_Bug = 1,
		k_ESteamNetworkingSocketsDebugOutputType_Error = 2,
		k_ESteamNetworkingSocketsDebugOutputType_Important = 3,
		k_ESteamNetworkingSocketsDebugOutputType_Warning = 4,
		k_ESteamNetworkingSocketsDebugOutputType_Msg = 5,
		k_ESteamNetworkingSocketsDebugOutputType_Verbose = 6,
		k_ESteamNetworkingSocketsDebugOutputType_Debug = 7,
		k_ESteamNetworkingSocketsDebugOutputType_Everything = 8,
		k_ESteamNetworkingSocketsDebugOutputType__Force32Bit = int.MaxValue
	}
}
namespace Steamworks
{
	public enum EItemStatistic
	{
		k_EItemStatistic_NumSubscriptions,
		k_EItemStatistic_NumFavorites,
		k_EItemStatistic_NumFollowers,
		k_EItemStatistic_NumUniqueSubscriptions,
		k_EItemStatistic_NumUniqueFavorites,
		k_EItemStatistic_NumUniqueFollowers,
		k_EItemStatistic_NumUniqueWebsiteViews,
		k_EItemStatistic_ReportScore,
		k_EItemStatistic_NumSecondsPlayed,
		k_EItemStatistic_NumPlaytimeSessions,
		k_EItemStatistic_NumComments,
		k_EItemStatistic_NumSecondsPlayedDuringTimePeriod,
		k_EItemStatistic_NumPlaytimeSessionsDuringTimePeriod
	}
}
