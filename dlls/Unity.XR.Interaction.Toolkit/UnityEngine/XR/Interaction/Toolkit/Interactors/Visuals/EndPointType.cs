using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals
{
	public enum EndPointType
	{
		None,
		EmptyCastHit,
		ValidCastHit,
		AttachPoint,
		UI
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Attachment
{
	[MovedFrom("UnityEngine.XR.Interaction.Toolkit.Interaction")]
	public interface IAttachPointVelocityProvider
	{
		Vector3 GetAttachPointVelocity();

		Vector3 GetAttachPointAngularVelocity();
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation
{
}
