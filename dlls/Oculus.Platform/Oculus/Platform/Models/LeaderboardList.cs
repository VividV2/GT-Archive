using System;
using System;
using System;

namespace Oculus.Platform.Models;

public class PaidOffer(IntPtr o)
{
	public readonly Price Price = new Price(CAPI.ovr_PaidOffer_GetPrice(o));

	public readonly OfferTerm SubscriptionTerm = CAPI.ovr_PaidOffer_GetSubscriptionTerm(o);
}
