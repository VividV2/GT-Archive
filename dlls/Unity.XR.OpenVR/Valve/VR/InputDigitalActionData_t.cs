using System.Runtime.InteropServices;

namespace Valve.VR
{
	public struct VRVulkanTextureArrayData_t
	{
		public uint m_unArrayIndex;

		public uint m_unArraySize;
	}
}
namespace Valve.VR
{
	public struct VROverlayView_t
	{
		public ulong overlayHandle;

		public Texture_t texture;

		public VRTextureBounds_t textureBounds;
	}
}
namespace Valve.VR
{
	public struct InputDigitalActionData_t
	{
		[MarshalAs(UnmanagedType.I1)]
		public bool bActive;

		public ulong activeOrigin;

		[MarshalAs(UnmanagedType.I1)]
		public bool bState;

		[MarshalAs(UnmanagedType.I1)]
		public bool bChanged;

		public float fUpdateTime;
	}
}
namespace Valve.VR
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
