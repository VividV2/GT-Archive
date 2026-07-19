using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayerSegmentsRequest : PlayFabRequestCommon
	{
	}
}
namespace PlayFab.ClientModels
{
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetLeaderboardAroundPlayerRequest : PlayFabRequestCommon
	{
		public int? MaxResultsCount;

		public string PlayFabId;

		public PlayerProfileViewConstraints ProfileConstraints;

		public string StatisticName;

		public int? Version;
	}
}
