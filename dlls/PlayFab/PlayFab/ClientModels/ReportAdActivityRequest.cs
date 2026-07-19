using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class ReportAdActivityRequest : PlayFabRequestCommon
	{
		public AdActivity Activity;

		public string PlacementId;

		public string RewardId;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginResult : PlayFabLoginResultCommon
	{
		public EntityTokenResponse EntityToken;

		public GetPlayerCombinedInfoResultPayload InfoResultPayload;

		public DateTime? LastLoginTime;

		public bool NewlyCreated;

		public string PlayFabId;

		public string SessionTicket;

		public UserSettings SettingsForUser;

		public TreatmentAssignment TreatmentAssignment;

		public LoginResult()
		{
			base..ctor();
		}
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithPlayFabRequest : PlayFabRequestCommon
	{
		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string Password;

		public string TitleId;

		public string Username;

		public LoginWithPlayFabRequest()
		{
			base..ctor();
		}
	}
}
