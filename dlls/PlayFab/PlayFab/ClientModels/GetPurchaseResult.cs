using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithPlayFabRequest : PlayFabRequestCommon
	{
		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string Password;

		public string TitleId;

		public string Username;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPurchaseResult : PlayFabResultCommon
	{
		public string OrderId;

		public string PaymentProvider;

		public DateTime PurchaseDate;

		public string TransactionId;

		public string TransactionStatus;
	}
}
