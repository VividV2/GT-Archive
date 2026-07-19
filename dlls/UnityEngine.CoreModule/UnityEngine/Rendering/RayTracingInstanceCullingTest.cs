using System.Collections.Generic;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	public struct RayTracingInstanceCullingTest
	{
		public uint instanceMask;

		public int layerMask;

		public int shadowCastingModeMask;

		public bool allowOpaqueMaterials;

		public bool allowTransparentMaterials;

		public bool allowAlphaTestedMaterials;

		public bool allowVisualEffects;
	}
}
namespace UnityEngine.Rendering
{
	internal delegate void GPUDrivenRendererDataCallback(in GPUDrivenRendererGroupData rendererData, IList<Mesh> meshes, IList<Material> materials);
}
