using System;
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
	public struct HmdQuaternion_t
	{
		public double w;

		public double x;

		public double y;

		public double z;
	}
}
