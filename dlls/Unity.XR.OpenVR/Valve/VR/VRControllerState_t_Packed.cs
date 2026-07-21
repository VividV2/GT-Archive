namespace Valve.VR
{
	public enum EVRInputFilterCancelType
	{
		VRInputFilterCancel_Timers,
		VRInputFilterCancel_Momentum
	}
}
namespace Valve.VR
{
	public struct VROverlayIntersectionMaskPrimitive_t
	{
		public EVROverlayIntersectionMaskPrimitiveType m_nPrimitiveType;

		public VROverlayIntersectionMaskPrimitive_Data_t m_Primitive;
	}
}
