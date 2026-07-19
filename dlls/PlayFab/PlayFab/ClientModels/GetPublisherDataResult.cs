using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPublisherDataResult : PlayFabResultCommon
	{
		public Dictionary<string, string> Data;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkGoogleAccountRequest : PlayFabRequestCommon
	{
		public bool? ForceLink;

		public string ServerAuthCode;
	}
}
namespace PlayFab.ClientModels
{
}
