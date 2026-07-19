namespace Valve.VR
{
	public struct VRTextureBounds_t
	{
		public float uMin;

		public float vMin;

		public float uMax;

		public float vMax;
	}
}
namespace Valve.VR
{
	public struct VREvent_ProgressUpdate_t
	{
		public ulong ulApplicationPropertyContainer;

		public ulong pathDevice;

		public ulong pathInputSource;

		public ulong pathProgressAction;

		public ulong pathIcon;

		public float fProgress;
	}
}
namespace Valve.VR
{
	public enum EVRInputStringBits
	{
		VRInputString_Hand = 1,
		VRInputString_ControllerType = 2,
		VRInputString_InputSource = 4,
		VRInputString_All = -1
	}
}
