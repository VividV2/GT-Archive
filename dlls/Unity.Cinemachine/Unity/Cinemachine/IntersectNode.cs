namespace Unity.Cinemachine
{
	internal struct IntersectNode(Point64 pt, Active edge1, Active edge2)
	{
		public readonly Point64 pt = pt;

		public readonly Active edge1 = edge1;

		public readonly Active edge2 = edge2;
	}
}
namespace Unity.Cinemachine
{
	internal sealed class CinemachineShotPlayable : PlayableBehaviour
	{
		public CinemachineVirtualCameraBase VirtualCamera;

		public bool IsValid => VirtualCamera != null;
	}
}
