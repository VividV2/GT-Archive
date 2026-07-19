using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ConsumePSNEntitlementsResult : PlayFabResultCommon
	{
		public List<ItemInstance> ItemsGranted;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayerStatisticsRequest : PlayFabRequestCommon
	{
		public List<string> StatisticNames;

		public List<StatisticNameVersion> StatisticNameVersions;
	}
}
