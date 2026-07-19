namespace PlayFab.ClientModels
{
}
namespace PlayFab.ClientModels
{
	public enum SubscriptionProviderStatus
	{
		NoError,
		Cancelled,
		UnknownError,
		BillingError,
		ProductUnavailable,
		CustomerDidNotAcceptPriceChange,
		FreeTrial,
		PaymentPending
	}
}
