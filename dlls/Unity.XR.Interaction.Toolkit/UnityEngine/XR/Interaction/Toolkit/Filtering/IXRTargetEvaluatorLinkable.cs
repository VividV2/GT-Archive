using UnityEngine.XR.Interaction.Toolkit.Interactors;

namespace UnityEngine.XR.Interaction.Toolkit.Filtering;

public interface IXRTargetEvaluatorLinkable
{
	void OnLink(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor interactor);

	void OnUnlink(UnityEngine.XR.Interaction.Toolkit.Interactors.IXRInteractor interactor);
}
