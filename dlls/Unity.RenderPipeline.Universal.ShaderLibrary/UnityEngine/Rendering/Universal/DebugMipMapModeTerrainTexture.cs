namespace UnityEngine.Rendering.Universal
{
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@bc6f352be672\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
	public enum DebugFullScreenMode
	{
		None,
		Depth,
		[InspectorName("Motion Vector (100x, normalized)")]
		MotionVector,
		AdditionalLightsShadowMap,
		MainLightShadowMap,
		AdditionalLightsCookieAtlas,
		ReflectionProbeAtlas,
		STP
	}
}
namespace UnityEngine.Rendering.Universal
{
	[GenerateHLSL(PackingRules.Exact, true, false, false, 1, false, false, false, -1, ".\\Library\\PackageCache\\com.unity.render-pipelines.universal@bc6f352be672\\ShaderLibrary\\Debug\\DebugViewEnums.cs")]
	public enum DebugMipMapModeTerrainTexture
	{
		Control,
		[InspectorName("Layer 0 - Diffuse")]
		Layer0,
		[InspectorName("Layer 1 - Diffuse")]
		Layer1,
		[InspectorName("Layer 2 - Diffuse")]
		Layer2,
		[InspectorName("Layer 3 - Diffuse")]
		Layer3
	}
}
