using UnityEngine.Bindings;

namespace UnityEngine
{
	public enum FilterMode
	{
		Point,
		Bilinear,
		Trilinear
	}
}
namespace UnityEngine.Rendering
{
	[VisibleToOtherModules]
	internal enum DefaultShaderType
	{
		Default,
		AutodeskInteractive,
		AutodeskInteractiveTransparent,
		AutodeskInteractiveMasked,
		TerrainDetailLit,
		TerrainDetailGrass,
		TerrainDetailGrassBillboard,
		SpeedTree7,
		SpeedTree8,
		SpeedTree9
	}
}
