using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class AddUsernamePasswordResult : PlayFabResultCommon
	{
		public string Username;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class ConsumePSNEntitlementsResult : PlayFabResultCommon
	{
		public System.Collections.Generic.List<ItemInstance> ItemsGranted;
	}
}
