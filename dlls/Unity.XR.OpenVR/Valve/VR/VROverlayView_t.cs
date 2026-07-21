namespace Valve.VR
{
	public struct VROverlayView_t
	{
		public ulong overlayHandle;

		public Texture_t texture;

		public VRTextureBounds_t textureBounds;
	}
}
namespace Valve.VR
{
	public enum ETrackedControllerRole
	{
		Invalid = 0,
		LeftHand = 1,
		RightHand = 2,
		OptOut = 3,
		Treadmill = 4,
		Stylus = 5,
		Max = 5
	}
}
namespace Valve.VR
{
}
