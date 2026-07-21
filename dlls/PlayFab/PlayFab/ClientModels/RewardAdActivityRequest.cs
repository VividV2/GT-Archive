using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class UnlinkNintendoAccountRequest : PlayFabRequestCommon
	{
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class RewardAdActivityRequest : PlayFabRequestCommon
	{
		public string PlacementId;

		public string RewardId;
	}
}
