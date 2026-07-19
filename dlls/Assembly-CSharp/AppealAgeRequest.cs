using System;

namespace GorillaNetworking;

public class GetAcceptedAgreementsRequest
{
	public string[] AgreementKeys;
}
public interface IRequestableOwnershipGuardCallbacks
{
	void OnOwnershipTransferred(NetPlayer toPlayer, NetPlayer fromPlayer);

	bool OnOwnershipRequest(NetPlayer fromPlayer);

	void OnMyOwnerLeft();

	bool OnMasterClientAssistedTakeoverRequest(NetPlayer fromPlayer, NetPlayer toPlayer);

	void OnMyCreatorLeft();
}
[Serializable]
public class AppealAgeRequest : KIDRequestData
{
	public int Age;

	public string Email;

	public string Locale;
}
