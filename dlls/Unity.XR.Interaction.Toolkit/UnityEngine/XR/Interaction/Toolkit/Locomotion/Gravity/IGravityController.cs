namespace UnityEngine.XR.Interaction.Toolkit.Interactors.Visuals
{
	public enum LineDynamicsMode
	{
		Traditional,
		RetractOnHitLoss,
		ExpandFromHitPoint
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Locomotion.Gravity
{
	public interface IGravityController
	{
		bool canProcess { get; }

		bool gravityPaused { get; }

		bool TryLockGravity(GravityOverride gravityOverride);

		void RemoveGravityLock();

		void OnGravityLockChanged(GravityOverride gravityOverride);

		void OnGroundedChanged(bool isGrounded);
	}
}
