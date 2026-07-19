using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithNintendoSwitchDeviceIdRequest : PlayFabRequestCommon
	{
		public bool? CreateAccount;

		public string EncryptedRequest;

		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string NintendoSwitchDeviceId;

		public string PlayerSecret;

		public string TitleId;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkCustomIDRequest : PlayFabRequestCommon
	{
		public string CustomId;

		public bool? ForceLink;
	}
}
