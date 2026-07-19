using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels;

[Serializable]
public class LoginWithFacebookInstantGamesIdRequest : PlayFabRequestCommon
{
	public bool? CreateAccount;

	public string EncryptedRequest;

	public string FacebookInstantGamesSignature;

	public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

	public string PlayerSecret;

	public string TitleId;
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class StatisticNameVersion : PlayFabBaseModel
	{
		public string StatisticName;

		public uint Version;
	}
}
