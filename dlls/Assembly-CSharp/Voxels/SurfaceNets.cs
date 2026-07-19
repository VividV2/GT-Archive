using System;
using Unity.Collections;
using Unity.Jobs;
using Unity.Mathematics;
using UnityEngine;
using System;
using UnityEngine;

[Serializable]
public struct MatrixBSPNode
{
	[SerializeField]
	public int matrixIndex;

	[SerializeField]
	public int outsideChildIndex;
}
namespace Voxels;

public static class SurfaceNets
{
	public static JobHandle Generate(NativeArray<byte> sdf, int3 shape, int3 min, int3 max, SurfaceNetsBuffer buffer, JobHandle dependency = default(JobHandle))
	{
		if (sdf.Length != shape.x * shape.y * shape.z)
		{
			throw new ArgumentException("SDF size does not match shape dimensions.");
		}
		return IJobExtensions.Schedule(new SurfaceNetsJob
		{
			sdf = sdf,
			shape = shape,
			min = min,
			max = max,
			buffer = buffer,
			isoLevel = 0f.ToByte()
		}, dependency);
	}
}
