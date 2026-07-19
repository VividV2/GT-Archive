using System;
using System;

namespace Valve.VR
{
	public struct Compositor_BenchmarkResults
	{
		public float m_flMegaPixelsPerSecond;

		public float m_flHmdRecommendedMegaPixelsPerSecond;
	}
}
namespace Valve.VR
{
	public struct VRTextureWithPose_t
	{
		public IntPtr handle;

		public ETextureType eType;

		public EColorSpace eColorSpace;

		public HmdMatrix34_t mDeviceToAbsoluteTracking;
	}
}
