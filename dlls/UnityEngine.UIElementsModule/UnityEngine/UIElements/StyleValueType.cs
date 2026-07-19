using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	public enum FillRule
	{
		NonZero,
		OddEven
	}
}
namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal enum StyleValueType
	{
		Invalid,
		Keyword,
		Float,
		Dimension,
		Color,
		ResourcePath,
		AssetReference,
		Enum,
		Variable,
		String,
		Function,
		CommaSeparator,
		ScalableImage,
		MissingAssetReference
	}
}
