using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayFabIDsFromGenericIDsResult : PlayFabResultCommon
	{
		public List<GenericPlayFabIdPair> Data;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetLeaderboardAroundPlayerResult : PlayFabResultCommon
	{
		public List<PlayerLeaderboardEntry> Leaderboard;

		public DateTime? NextReset;

		public int Version;
	}
}
