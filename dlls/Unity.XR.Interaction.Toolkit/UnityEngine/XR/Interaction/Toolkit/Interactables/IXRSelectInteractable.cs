using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;
using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.XR.Interaction.Toolkit.Interactables;
using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Inputs
{
}
namespace UnityEngine.XR.Interaction.Toolkit.Filtering
{
	public interface IXRSelectFilter
	{
		bool canProcess { get; }

		bool Process(IXRSelectInteractor interactor, IXRSelectInteractable interactable);
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Comfort
{
}
namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public interface IXRInteractionOverrideGroup : IXRInteractionGroup
	{
		void AddInteractionOverrideForGroupMember(IXRGroupMember sourceGroupMember, IXRGroupMember overrideGroupMember);

		bool GroupMemberIsPartOfOverrideChain(IXRGroupMember sourceGroupMember, IXRGroupMember potentialOverrideGroupMember);

		bool RemoveInteractionOverrideForGroupMember(IXRGroupMember sourceGroupMember, IXRGroupMember overrideGroupMember);

		bool ClearInteractionOverridesForGroupMember(IXRGroupMember sourceGroupMember);

		void GetInteractionOverridesForGroupMember(IXRGroupMember sourceGroupMember, HashSet<IXRGroupMember> results);

		bool ShouldOverrideActiveInteraction(out IXRSelectInteractor overridingInteractor);

		bool ShouldAnyMemberOverrideInteraction(IXRInteractor interactingInteractor, out IXRSelectInteractor overridingInteractor);
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals
{
	public enum LineDynamicsMode
	{
		Traditional,
		RetractOnHitLoss,
		ExpandFromHitPoint
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Interactables
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public interface IXRSelectInteractable : IXRInteractable
	{
		SelectEnterEvent firstSelectEntered { get; }

		SelectExitEvent lastSelectExited { get; }

		SelectEnterEvent selectEntered { get; }

		SelectExitEvent selectExited { get; }

		List<IXRSelectInteractor> interactorsSelecting { get; }

		IXRSelectInteractor firstInteractorSelecting { get; }

		bool isSelected { get; }

		InteractableSelectMode selectMode { get; }

		bool IsSelectableBy(IXRSelectInteractor interactor);

		Pose GetAttachPoseOnSelect(IXRSelectInteractor interactor);

		Pose GetLocalAttachPoseOnSelect(IXRSelectInteractor interactor);

		void OnSelectEntering(SelectEnterEventArgs args);

		void OnSelectEntered(SelectEnterEventArgs args);

		void OnSelectExiting(SelectExitEventArgs args);

		void OnSelectExited(SelectExitEventArgs args);
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Interactors
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit")]
	public enum TargetPriorityMode
	{
		None,
		HighestPriorityOnly,
		All
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Interactables.Visuals
{
}
namespace UnityEngine.XR.Interaction.Toolkit.Interactables
{
}
