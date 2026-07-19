using System;
using System;

namespace Valve.VR;

public struct VRTextureDepthInfo_t
{
	public IntPtr handle;

	public HmdMatrix44_t mProjection;

	public HmdVector2_t vRange;
}
namespace Valve.VR
{
	public struct VRVulkanTextureArrayData_t
	{
		public uint m_unArrayIndex;

		public uint m_unArraySize;
	}
}
