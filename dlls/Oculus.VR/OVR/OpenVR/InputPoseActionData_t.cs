namespace OVR.OpenVR
{
	public struct VREvent_t
	{
		public uint eventType;

		public uint trackedDeviceIndex;

		public float eventAgeSeconds;

		public VREvent_Data_t data;
	}
}
namespace OVR.OpenVR
{
	public struct InputPoseActionData_t
	{
		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
		public bool bActive;

		public ulong activeOrigin;

		public TrackedDevicePose_t pose;
	}
}
