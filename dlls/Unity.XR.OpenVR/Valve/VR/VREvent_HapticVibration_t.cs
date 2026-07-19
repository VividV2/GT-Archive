namespace Valve.VR
{
	public struct VREvent_SpatialAnchor_t
	{
		public uint unHandle;
	}
}
namespace Valve.VR
{
	public struct VREvent_EditingCameraSurface_t
	{
		public ulong overlayHandle;

		public uint nVisualMode;
	}
}
namespace Valve.VR
{
	public struct VREvent_HapticVibration_t
	{
		public ulong containerHandle;

		public ulong componentHandle;

		public float fDurationSeconds;

		public float fFrequency;

		public float fAmplitude;
	}
}
