using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayFabIDsFromFacebookInstantGamesIdsRequest : PlayFabRequestCommon
	{
		public List<string> FacebookInstantGamesIds;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkGameCenterAccountRequest : PlayFabRequestCommon
	{
		public bool? ForceLink;

		public string GameCenterId;

		public string PublicKeyUrl;

		public string Salt;

		public string Signature;

		public string Timestamp;
	}
}
