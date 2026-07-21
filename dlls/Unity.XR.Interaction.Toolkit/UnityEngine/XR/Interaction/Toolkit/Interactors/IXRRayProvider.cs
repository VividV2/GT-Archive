using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation
{
}
namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Climbing
{
}
namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public interface IXRReticleDirectionProvider
	{
		void GetReticleDirection(IXRInteractor interactor, Vector3 hitNormal, out Vector3 reticleUp, out Vector3? optionalReticleForward);
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public interface IXRRayProvider
	{
		Vector3 rayEndPoint { get; }

		Transform rayEndTransform { get; }

		Transform GetOrCreateRayOrigin();

		Transform GetOrCreateAttachTransform();

		void SetRayOrigin(Transform newOrigin);

		void SetAttachTransform(Transform newAttach);
	}
}
