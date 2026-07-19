using System;
using System;
using System;

namespace OVR.OpenVR
{
	public struct VREvent_Scroll_t
	{
		public float xdelta;

		public float ydelta;

		public uint repeatCount;
	}
}
namespace OVR.OpenVR
{
	public struct CVRSettingHelper
	{
		public IntPtr m_pSettings;
	}
}
namespace OVR.OpenVR
{
	public struct ImuSample_t
	{
		public double fSampleTime;

		public HmdVector3d_t vAccel;

		public HmdVector3d_t vGyro;

		public uint unOffScaleFlags;
	}
}
