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
	[Serializable]
	public class GrantCharacterToUserRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public string CharacterName;

		public string ItemId;
	}
}
namespace PlayFab.ClientModels
{
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithFacebookRequest : PlayFabRequestCommon
	{
		public string AccessToken;

		public bool? CreateAccount;

		public string EncryptedRequest;

		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string PlayerSecret;

		public string TitleId;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayFabIDsFromGameCenterIDsRequest : PlayFabRequestCommon
	{
		public List<string> GameCenterIDs;
	}
}
