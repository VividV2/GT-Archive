using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Valve.VR
{
	public enum EDeviceType
	{
		Invalid = -1,
		DirectX11,
		Vulkan
	}
}
namespace Valve.VR
{
	public struct HmdColor_t
	{
		public float r;

		public float g;

		public float b;

		public float a;
	}
}
namespace Valve.VR
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
namespace Valve.VR
{
}
