namespace OVR.OpenVR
{
	public struct HmdMatrix34_t
	{
		public float m0;

		public float m1;

		public float m2;

		public float m3;

		public float m4;

		public float m5;

		public float m6;

		public float m7;

		public float m8;

		public float m9;

		public float m10;

		public float m11;
	}
}
namespace OVR.OpenVR
{
	public enum EVRTrackedCameraFrameLayout
	{
		Mono = 1,
		Stereo = 2,
		VerticalLayout = 0x10,
		HorizontalLayout = 0x20
	}
}
namespace OVR.OpenVR
{
	public struct VROverlayIntersectionParams_t
	{
		public HmdVector3_t vSource;

		public HmdVector3_t vDirection;

		public ETrackingUniverseOrigin eOrigin;
	}
}
namespace OVR.Input
{
}
