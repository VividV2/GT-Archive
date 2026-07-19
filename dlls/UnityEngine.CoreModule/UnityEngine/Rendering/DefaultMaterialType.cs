using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	public enum ShadingRateCombinerStage
	{
		Primitive,
		Fragment
	}
}
namespace UnityEngine.Rendering
{
	[VisibleToOtherModules]
	internal enum DefaultMaterialType
	{
		Default,
		Particle,
		Line,
		Terrain,
		Sprite,
		SpriteMask,
		UGUI,
		UGUI_Overdraw,
		UGUI_ETC1Supported
	}
}
