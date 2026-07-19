using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPaymentTokenRequest : PlayFabRequestCommon
	{
		public string TokenProvider;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetUserInventoryResult : PlayFabResultCommon
	{
		public System.Collections.Generic.List<ItemInstance> Inventory;

		public System.Collections.Generic.Dictionary<string, int> VirtualCurrency;

		public System.Collections.Generic.Dictionary<string, VirtualCurrencyRechargeTime> VirtualCurrencyRechargeTimes;
	}
}
