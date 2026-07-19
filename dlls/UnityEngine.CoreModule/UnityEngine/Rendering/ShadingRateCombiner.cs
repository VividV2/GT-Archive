using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	public enum ShadingRateCombiner
	{
		Keep,
		Override,
		Min,
		Max
	}
}
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
namespace UnityEngine
{
}
