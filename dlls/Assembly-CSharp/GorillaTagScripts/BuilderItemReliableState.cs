using GorillaExtensions;
using Photon.Pun;
using Unity.Mathematics;
using UnityEngine;

public enum GetSessionResponseType
{
	OK = 200,
	NOT_FOUND = 204,
	LOST = 404,
	ERROR = 0
}
public interface IFXEffectContext<T> where T : IFXEffectContextObject
{
	T effectContext { get; }

	FXSystemSettings settings { get; }
}
namespace GorillaTagScripts
{
	public class BuilderItemReliableState : MonoBehaviour, IPunObservable
	{
		public Vector3 rightHandAttachPos = Vector3.zero;

		public Quaternion rightHandAttachRot = Quaternion.identity;

		public Vector3 leftHandAttachPos = Vector3.zero;

		public Quaternion leftHandAttachRot = Quaternion.identity;

		public bool dirty;

		public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
		{
			if (stream.IsWriting)
			{
				stream.SendNext(rightHandAttachPos);
				stream.SendNext(rightHandAttachRot);
				stream.SendNext(leftHandAttachPos);
				stream.SendNext(leftHandAttachRot);
				return;
			}
			rightHandAttachPos = (Vector3)stream.ReceiveNext();
			rightHandAttachRot = (Quaternion)stream.ReceiveNext();
			leftHandAttachPos = (Vector3)stream.ReceiveNext();
			leftHandAttachRot = (Quaternion)stream.ReceiveNext();
			if (!GTExt.IsValid(in rightHandAttachPos, 10000f))
			{
				rightHandAttachPos = Vector3.zero;
			}
			if (!GTExt.IsValid(in rightHandAttachRot))
			{
				rightHandAttachRot = quaternion.identity;
			}
			if (!GTExt.IsValid(in leftHandAttachPos, 10000f))
			{
				leftHandAttachPos = Vector3.zero;
			}
			if (!GTExt.IsValid(in leftHandAttachRot))
			{
				leftHandAttachRot = quaternion.identity;
			}
			dirty = true;
		}
	}
}
namespace GorillaNetworking
{
}
