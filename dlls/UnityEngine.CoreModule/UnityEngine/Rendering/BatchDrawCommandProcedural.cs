namespace UnityEngine.Rendering
{
	public struct BatchDrawCommandProcedural
	{
		public BatchDrawCommandFlags flags;

		public BatchID batchID;

		public BatchMaterialID materialID;

		public ushort splitVisibilityMask;

		public ushort lightmapIndex;

		public int sortingPosition;

		public uint visibleOffset;

		public uint visibleCount;

		public MeshTopology topology;

		public GraphicsBufferHandle indexBufferHandle;

		public uint baseVertex;

		public uint indexOffsetBytes;

		public uint elementCount;
	}
}
namespace UnityEngine.Rendering
{
	internal struct CullingAllocationInfo
	{
		public unsafe VisibleLight* visibleLightsPtr;

		public unsafe VisibleLight* visibleOffscreenVertexLightsPtr;

		public unsafe VisibleReflectionProbe* visibleReflectionProbesPtr;

		public int visibleLightCount;

		public int visibleOffscreenVertexLightCount;

		public int visibleReflectionProbeCount;
	}
}
namespace UnityEngine.Rendering
{
}
