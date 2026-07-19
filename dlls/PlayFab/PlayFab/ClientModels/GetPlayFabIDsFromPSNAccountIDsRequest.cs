using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class AdRewardItemGranted : PlayFabBaseModel
	{
		public string CatalogId;

		public string DisplayName;

		public string InstanceId;

		public string ItemId;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayFabIDsFromPSNAccountIDsRequest : PlayFabRequestCommon
	{
		public int? IssuerId;

		public System.Collections.Generic.List<string> PSNAccountIDs;
	}
}
