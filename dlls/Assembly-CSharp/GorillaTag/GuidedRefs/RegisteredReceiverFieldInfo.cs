using UnityEngine.Serialization;
using UnityEngine.Serialization;

namespace GorillaTag.GuidedRefs;

public struct RegisteredReceiverFieldInfo
{
	[FormerlySerializedAs("receiver")]
	public IGuidedRefReceiverMono receiverMono;

	public int fieldId;

	public int index;
}
public enum GTShopEventType
{
	item_select,
	item_try_on,
	cart_item_add,
	cart_item_remove,
	checkout_start,
	checkout_cancel,
	register_visit,
	external_item_claim
}
