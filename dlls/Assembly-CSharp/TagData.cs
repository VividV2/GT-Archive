using System.Collections.Generic;
using System.Collections.Generic;

public interface IRequestableOwnershipGuardCallbacks
{
	void OnOwnershipTransferred(NetPlayer toPlayer, NetPlayer fromPlayer);

	bool OnOwnershipRequest(NetPlayer fromPlayer);

	void OnMyOwnerLeft();

	bool OnMasterClientAssistedTakeoverRequest(NetPlayer fromPlayer, NetPlayer toPlayer);

	void OnMyCreatorLeft();
}
public struct TelemetryData
{
	public string EventName;

	public string[] CustomTags;

	public Dictionary<string, string> BodyData;
}
