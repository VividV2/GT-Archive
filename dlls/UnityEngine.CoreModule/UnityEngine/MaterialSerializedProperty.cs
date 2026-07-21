namespace UnityEngine
{
	internal enum MaterialSerializedProperty
	{
		None = 0,
		LightmapFlags = 2,
		EnableInstancingVariants = 4,
		DoubleSidedGI = 8,
		CustomRenderQueue = 0x10
	}
}
namespace UnityEngine
{
	[NativeType("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum ComputeBufferMode
	{
		Immutable,
		Dynamic,
		[Obsolete("ComputeBufferMode.Circular is deprecated (legacy mode)")]
		Circular,
		[Obsolete("ComputeBufferMode.StreamOut is deprecated (internal use only)")]
		StreamOut,
		SubUpdates
	}
}
namespace UnityEngine.Playables
{
}
