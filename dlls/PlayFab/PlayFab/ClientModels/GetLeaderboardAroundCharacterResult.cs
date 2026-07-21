using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetLeaderboardAroundCharacterResult : PlayFabResultCommon
	{
		public List<CharacterLeaderboardEntry> Leaderboard;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class CharacterLeaderboardEntry : PlayFabBaseModel
	{
		public string CharacterId;

		public string CharacterName;

		public string CharacterType;

		public string DisplayName;

		public string PlayFabId;

		public int Position;

		public int StatValue;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetCharacterStatisticsRequest : PlayFabRequestCommon
	{
		public string CharacterId;
	}
}
