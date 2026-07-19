using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
	[Serializable]
	public class EmptyResult : PlayFabResultCommon
	{
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class AddUsernamePasswordRequest : PlayFabRequestCommon
	{
		public string Email;

		public string Password;

		public string Username;
	}
}
