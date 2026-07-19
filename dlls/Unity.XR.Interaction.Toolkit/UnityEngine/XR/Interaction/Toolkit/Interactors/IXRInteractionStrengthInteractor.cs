using System.Collections.Generic;
using Unity.XR.CoreUtils.Bindings.Variables;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public interface IXRTargetPriorityInteractor : IXRInteractor
	{
		TargetPriorityMode targetPriorityMode { get; }

		List<IXRSelectInteractable> targetsForSelection { get; }
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public interface IXRInteractionStrengthInteractor : IXRInteractor
	{
		Unity.XR.CoreUtils.Bindings.Variables.IReadOnlyBindableVariable<float> largestInteractionStrength { get; }

		float GetInteractionStrength(IXRInteractable interactable);

		void ProcessInteractionStrength(XRInteractionUpdateOrder.UpdatePhase updatePhase);
	}
}
