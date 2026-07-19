using System;

namespace Valve.VR
{
	public struct RenderModel_t
	{
		public IntPtr rVertexData;

		public uint unVertexCount;

		public IntPtr rIndexData;

		public uint unTriangleCount;

		public int diffuseTextureId;
	}
}
namespace Valve.VR
{
	public struct VROverlayIntersectionResults_t
	{
		public HmdVector3_t vPoint;

		public HmdVector3_t vNormal;

		public HmdVector2_t vUVs;

		public float fDistance;
	}
}
