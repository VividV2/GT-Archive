namespace UnityEngine.Animations.Rigging
{
	internal struct SyncableProperties
	{
		public RigProperties rig;

		public ConstraintProperties[] constraints;
	}
}
namespace UnityEngine.Animations.Rigging
{
	public interface ITwistCorrectionData
	{
		Transform source { get; }

		WeightedTransformArray twistNodes { get; }

		Vector3 twistAxis { get; }

		string twistNodesProperty { get; }
	}
}
