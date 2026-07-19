using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	public struct BatchDrawCommandProceduralIndirect
	{
		public BatchDrawCommandFlags flags;

		public BatchID batchID;

		public BatchMaterialID materialID;

		public ushort splitVisibilityMask;

		public ushort lightmapIndex;

		public int sortingPosition;

		public uint visibleOffset;

		public MeshTopology topology;

		public GraphicsBufferHandle indexBufferHandle;

		public GraphicsBufferHandle visibleInstancesBufferHandle;

		public uint visibleInstancesBufferWindowOffset;

		public uint visibleInstancesBufferWindowSizeBytes;

		public GraphicsBufferHandle indirectArgsBufferHandle;

		public uint indirectArgsBufferOffset;
	}
}
namespace UnityEngine.Rendering
{
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	public struct RayTracingInstanceCullingMaterialTest
	{
		public string[] deniedShaderPasses;

		public RayTracingInstanceCullingShaderTagConfig[] requiredShaderTags;
	}
}
namespace UnityEngine.Rendering
{
}
