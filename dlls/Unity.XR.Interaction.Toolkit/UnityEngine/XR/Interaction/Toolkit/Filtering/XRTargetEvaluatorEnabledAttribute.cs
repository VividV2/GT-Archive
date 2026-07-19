using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Readers
{
}
namespace UnityEngine.XR.Interaction.Toolkit.Transformers
{
	public interface IXRGrabTransformer
	{
		bool canProcess { get; }

		void OnLink(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable);

		void OnGrab(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable);

		void OnGrabCountChanged(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable, Pose targetPose, Vector3 localScale);

		void Process(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable, XRInteractionUpdateOrder.UpdatePhase updatePhase, ref Pose targetPose, ref Vector3 localScale);

		void OnUnlink(UnityEngine.XR.Interaction.Toolkit.Interactables.XRGrabInteractable grabInteractable);
	}
}
