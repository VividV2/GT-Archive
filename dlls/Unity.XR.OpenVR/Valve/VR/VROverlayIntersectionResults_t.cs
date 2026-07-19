using System.Runtime.InteropServices;

namespace Valve.VR
{
	public struct VROverlayIntersectionResults_t
	{
		public HmdVector3_t vPoint;

		public HmdVector3_t vNormal;

		public HmdVector2_t vUVs;

		public float fDistance;
	}
}
namespace Unity.XR.OpenVR
{
}
namespace Valve.VR
{
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
