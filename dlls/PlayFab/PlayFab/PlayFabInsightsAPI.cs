using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels;

[Serializable]
public class GetFriendsListRequest : PlayFabRequestCommon
{
	public bool? IncludeFacebookFriends;

	public bool? IncludeSteamFriends;

	public PlayerProfileViewConstraints ProfileConstraints;

	public string XboxToken;
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPhotonAuthenticationTokenRequest : PlayFabRequestCommon
	{
		public string PhotonApplicationId;
	}
}
