using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels;

[Serializable]
public class GetWindowsHelloChallengeResponse : PlayFabResultCommon
{
	public string Challenge;
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayFabIDsFromFacebookIDsResult : PlayFabResultCommon
	{
		public List<FacebookPlayFabIdPair> Data;
	}
}
namespace PlayFab.ClientModels
{
}
