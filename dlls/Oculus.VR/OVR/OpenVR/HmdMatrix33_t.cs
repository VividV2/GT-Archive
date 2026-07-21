using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	[StructLayout(LayoutKind.Explicit)]
	public struct VROverlayIntersectionMaskPrimitive_Data_t
	{
		[FieldOffset(0)]
		public IntersectionMaskRectangle_t m_Rectangle;

		[FieldOffset(0)]
		public IntersectionMaskCircle_t m_Circle;
	}
}
namespace OVR.OpenVR
{
	public struct HmdMatrix33_t
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
	}
}
