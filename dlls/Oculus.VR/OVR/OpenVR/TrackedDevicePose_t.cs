using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct VREvent_Notification_t
	{
		public ulong ulUserValue;

		public uint notificationId;
	}
}
namespace OVR.OpenVR
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
namespace OVR.OpenVR
{
}
