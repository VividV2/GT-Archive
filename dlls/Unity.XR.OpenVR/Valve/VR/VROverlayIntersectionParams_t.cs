namespace Valve.VR
{
	public struct VRControllerState_t
	{
		public uint unPacketNum;

		public ulong ulButtonPressed;

		public ulong ulButtonTouched;

		public VRControllerAxis_t rAxis0;

		public VRControllerAxis_t rAxis1;

		public VRControllerAxis_t rAxis2;

		public VRControllerAxis_t rAxis3;

		public VRControllerAxis_t rAxis4;
	}
}
namespace Valve.VR
{
	public enum EIOBufferMode
	{
		Read = 1,
		Write = 2,
		Create = 0x200
	}
}
namespace Valve.VR
{
	public struct VROverlayIntersectionParams_t
	{
		public HmdVector3_t vSource;

		public HmdVector3_t vDirection;

		public ETrackingUniverseOrigin eOrigin;
	}
}
namespace Valve.VR
{
	public struct VRActiveActionSet_t
	{
		public ulong ulActionSet;

		public ulong ulRestrictedToDevice;

		public ulong ulSecondaryActionSet;

		public uint unPadding;

		public int nPriority;
	}
}
