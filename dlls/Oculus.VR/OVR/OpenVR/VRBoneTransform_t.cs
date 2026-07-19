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
