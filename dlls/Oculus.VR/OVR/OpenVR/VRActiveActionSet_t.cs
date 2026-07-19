namespace OVR.OpenVR
{
	public enum EVRNotificationType
	{
		Transient,
		Persistent,
		Transient_SystemWithUserValue
	}
}
namespace OVR.OpenVR
{
	public struct VRBoneTransform_t
	{
		public HmdVector4_t position;

		public HmdQuaternionf_t orientation;
	}
}
namespace OVR.OpenVR
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
