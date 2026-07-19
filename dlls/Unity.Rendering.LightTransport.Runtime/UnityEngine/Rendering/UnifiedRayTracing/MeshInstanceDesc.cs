using System;
using System;

namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal struct MeshInstanceDesc(Mesh mesh, int subMeshIndex = 0)
	{
		public Mesh mesh = mesh;

		public int subMeshIndex = subMeshIndex;

		public Matrix4x4 localToWorldMatrix = Matrix4x4.identity;

		public uint mask = uint.MaxValue;

		public uint instanceID = uint.MaxValue;

		public bool enableTriangleCulling = true;

		public bool frontTriangleCounterClockwise = false;
	}
}
namespace UnityEngine.Rendering.UnifiedRayTracing
{
	internal interface IRayTracingAccelStruct : IDisposable
	{
		int AddInstance(MeshInstanceDesc meshInstance);

		void RemoveInstance(int instanceHandle);

		void ClearInstances();

		void UpdateInstanceTransform(int instanceHandle, Matrix4x4 localToWorldMatrix);

		void UpdateInstanceID(int instanceHandle, uint instanceID);

		void UpdateInstanceMask(int instanceHandle, uint mask);

		void Build(CommandBuffer cmd, GraphicsBuffer scratchBuffer);

		ulong GetBuildScratchBufferRequiredSizeInBytes();
	}
}
namespace UnityEngine.Rendering.UnifiedRayTracing
{
}
