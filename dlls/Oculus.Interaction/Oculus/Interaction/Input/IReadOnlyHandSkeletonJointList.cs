namespace Oculus.Interaction
{
	public interface IMovementProvider
	{
		IMovement CreateMovement();
	}
}
namespace Oculus.Interaction.Input
{
	public interface IReadOnlyHandSkeletonJointList
	{
		ref readonly HandSkeletonJoint this[int jointId] { get; }
	}
}
