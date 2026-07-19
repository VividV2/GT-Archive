using System;
using System;

namespace UnityEngine.Rendering
{
	public enum ShadingRateFragmentSize
	{
		[InspectorName("FragmentSize 1x1")]
		FragmentSize1x1,
		[InspectorName("FragmentSize 1x2")]
		FragmentSize1x2,
		[InspectorName("FragmentSize 2x1")]
		FragmentSize2x1,
		[InspectorName("FragmentSize 2x2")]
		FragmentSize2x2,
		[InspectorName("FragmentSize 1x4")]
		FragmentSize1x4,
		[InspectorName("FragmentSize 4x1")]
		FragmentSize4x1,
		[InspectorName("FragmentSize 2x4")]
		FragmentSize2x4,
		[InspectorName("FragmentSize 4x2")]
		FragmentSize4x2,
		[InspectorName("FragmentSize 4x4")]
		FragmentSize4x4
	}
}
namespace UnityEngine.Rendering
{
	[Flags]
	public enum PerObjectData
	{
		None = 0,
		LightProbe = 1,
		ReflectionProbes = 2,
		LightProbeProxyVolume = 4,
		Lightmaps = 8,
		LightData = 0x10,
		MotionVectors = 0x20,
		LightIndices = 0x40,
		ReflectionProbeData = 0x80,
		OcclusionProbe = 0x100,
		OcclusionProbeProxyVolume = 0x200,
		ShadowMask = 0x400
	}
}
namespace UnityEngine.Rendering
{
}
