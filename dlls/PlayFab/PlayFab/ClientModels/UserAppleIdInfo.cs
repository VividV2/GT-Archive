using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class UserAppleIdInfo : PlayFabBaseModel
	{
		public string AppleSubjectId;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class UnlockContainerItemResult : PlayFabResultCommon
	{
		public System.Collections.Generic.List<ItemInstance> GrantedItems;

		public string UnlockedItemInstanceId;

		public string UnlockedWithItemInstanceId;

		public System.Collections.Generic.Dictionary<string, uint> VirtualCurrency;
	}
}
