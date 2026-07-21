using System;
using System;

namespace UnityEngine.Rendering
{
	[Flags]
	internal enum DrawRendererFlags
	{
		None = 0,
		EnableDynamicBatching = 1,
		EnableInstancing = 2
	}
}
namespace UnityEngine.Rendering
{
	public enum BuiltinShaderType
	{
		DeferredShading,
		DeferredReflections,
		[Obsolete("LegacyDeferredLighting has been removed.", false)]
		LegacyDeferredLighting,
		ScreenSpaceShadows,
		DepthNormals,
		MotionVectors,
		LightHalo,
		LensFlare
	}
}
