using System;
using System;

namespace Valve.VR;

public struct VRVulkanDevice_t
{
	public IntPtr m_pInstance;

	public IntPtr m_pDevice;

	public IntPtr m_pPhysicalDevice;

	public IntPtr m_pQueue;

	public uint m_uQueueFamilyIndex;
}
namespace Valve.VR
{
	public enum EIOBufferError
	{
		IOBuffer_Success = 0,
		IOBuffer_OperationFailed = 100,
		IOBuffer_InvalidHandle = 101,
		IOBuffer_InvalidArgument = 102,
		IOBuffer_PathExists = 103,
		IOBuffer_PathDoesNotExist = 104,
		IOBuffer_Permission = 105
	}
}
