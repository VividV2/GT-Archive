using System;

namespace OVR.OpenVR
{
	public struct VRTextureDepthInfo_t
	{
		public IntPtr handle;

		public HmdMatrix44_t mProjection;

		public HmdVector2_t vRange;
	}
}
namespace OVR.OpenVR
{
	public struct VREvent_Chaperone_t
	{
		public ulong m_nPreviousUniverse;

		public ulong m_nCurrentUniverse;
	}
}
