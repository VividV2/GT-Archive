using System.Runtime.InteropServices;

namespace Valve.VR;

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
namespace Valve.VR
{
	public struct TrackedDevicePose_t
	{
		public HmdMatrix34_t mDeviceToAbsoluteTracking;

		public HmdVector3_t vVelocity;

		public HmdVector3_t vAngularVelocity;

		public ETrackingResult eTrackingResult;

		[MarshalAs(UnmanagedType.I1)]
		public bool bPoseIsValid;

		[MarshalAs(UnmanagedType.I1)]
		public bool bDeviceIsConnected;
	}
}
