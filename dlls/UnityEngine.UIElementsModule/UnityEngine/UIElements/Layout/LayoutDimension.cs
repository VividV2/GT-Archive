using System;

namespace UnityEngine.UIElements.Layout
{
	internal enum LayoutDimension
	{
		Width,
		Height
	}
}
namespace UnityEngine.UIElements.UIR
{
	[System.Flags]
	internal enum RenderDataFlags
	{
		IsGroupTransform = 1,
		IsIgnoringDynamicColorHint = 2,
		HasExtraData = 4,
		HasExtraMeshes = 8,
		IsSubTreeQuad = 0x10,
		IsNestedRenderTreeRoot = 0x20,
		IsClippingRectDirty = 0x40
	}
}
