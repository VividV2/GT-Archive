using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using System;

namespace UnityEngine.Rendering.Universal;

[Flags]
[Obsolete("Use RenderingLayerMask instead. #from(6000.2)")]
public enum LightLayerEnum
{
	Nothing = 0,
	LightLayerDefault = 1,
	LightLayer1 = 2,
	LightLayer2 = 4,
	LightLayer3 = 8,
	LightLayer4 = 0x10,
	LightLayer5 = 0x20,
	LightLayer6 = 0x40,
	LightLayer7 = 0x80,
	Everything = 0xFF
}
namespace UnityEngine.Rendering.Universal
{
	[BurstCompile]
	internal struct ReflectionProbeMinMaxZJob : IJobFor
	{
		public Fixed2<float4x4> worldToViews;

		[ReadOnly]
		public NativeArray<VisibleReflectionProbe> reflectionProbes;

		public NativeArray<float2> minMaxZs;

		public void Execute(int index)
		{
			float2 value = math.float2(float.MaxValue, float.MinValue);
			int index2 = index % reflectionProbes.Length;
			VisibleReflectionProbe visibleReflectionProbe = reflectionProbes[index2];
			int index3 = index / reflectionProbes.Length;
			float4x4 a = worldToViews[index3];
			float3 float5 = visibleReflectionProbe.bounds.center;
			float3 float6 = visibleReflectionProbe.bounds.extents;
			for (int i = 0; i < 8; i++)
			{
				int num = ((i << 1) & 2) - 1;
				int num2 = (i & 2) - 1;
				int num3 = ((i >> 1) & 2) - 1;
				float4 float7 = math.mul(a, math.float4(float5 + float6 * math.float3(num, num2, num3), 1f));
				float7.z *= -1f;
				value.x = math.min(value.x, float7.z);
				value.y = math.max(value.y, float7.z);
			}
			minMaxZs[index] = value;
		}
	}
}
