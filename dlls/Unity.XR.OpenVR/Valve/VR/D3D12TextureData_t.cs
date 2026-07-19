using System;

namespace Valve.VR
{
	public struct D3D12TextureData_t
	{
		public IntPtr m_pResource;

		public IntPtr m_pCommandQueue;

		public uint m_nNodeMask;
	}
}
namespace Valve.VR
{
	public struct VREvent_t
	{
		public uint eventType;

		public uint trackedDeviceIndex;

		public float eventAgeSeconds;

		public VREvent_Data_t data;
	}
}
