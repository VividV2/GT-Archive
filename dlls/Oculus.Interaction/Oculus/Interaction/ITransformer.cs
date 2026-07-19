namespace Oculus.Interaction.HandGrab
{
}
namespace Oculus.Interaction.Throw
{
}
namespace Oculus.Interaction.Locomotion
{
}
namespace Oculus.Interaction
{
}
namespace Oculus.Interaction.PoseDetection.Debug
{
}
namespace Oculus.Interaction
{
	public interface ITransformer
	{
		void Initialize(IGrabbable grabbable);

		void BeginTransform();

		void UpdateTransform();

		void EndTransform();
	}
}
