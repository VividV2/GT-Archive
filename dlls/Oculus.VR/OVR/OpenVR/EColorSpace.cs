namespace OVR.OpenVR
{
	public enum EColorSpace
	{
		Auto,
		Gamma,
		Linear
	}
}
namespace OVR.OpenVR
{
	public enum EVRSkeletalTransformSpace
	{
		Model,
		Parent,
		Additive
	}
}
namespace OVR.OpenVR
{
	public struct VREvent_InputActionManifestLoad_t
	{
		public ulong pathAppKey;

		public ulong pathMessage;

		public ulong pathMessageParam;

		public ulong pathManifestPath;
	}
}
