namespace Valve.VR
{
	public struct HmdRect2_t
	{
		public HmdVector2_t vTopLeft;

		public HmdVector2_t vBottomRight;
	}
}
namespace Valve.VR
{
	public struct VREvent_InputActionManifestLoad_t
	{
		public ulong pathAppKey;

		public ulong pathMessage;

		public ulong pathMessageParam;

		public ulong pathManifestPath;
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
