using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using PlayFab.SharedModels;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayerCombinedInfoRequest : PlayFabRequestCommon
	{
		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string PlayFabId;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayerTagsResult : PlayFabResultCommon
	{
		public string PlayFabId;

		public List<string> Tags;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetLeaderboardAroundCharacterRequest : PlayFabRequestCommon
	{
		public string CharacterId;

		public string CharacterType;

		public int? MaxResultsCount;

		public string StatisticName;
	}
}
