using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LinkNintendoAccountRequest : PlayFabRequestCommon
	{
		public bool? ForceLink;

		public string IdentityToken;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class PayForPurchaseResult : PlayFabResultCommon
	{
		public uint CreditApplied;

		public string OrderId;

		public string ProviderData;

		public string ProviderToken;

		public string PurchaseConfirmationPageURL;

		public string PurchaseCurrency;

		public uint PurchasePrice;

		public TransactionStatus? Status;

		public System.Collections.Generic.Dictionary<string, int> VCAmount;

		public System.Collections.Generic.Dictionary<string, int> VirtualCurrency;
	}
}
