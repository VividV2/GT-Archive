using UnityEngine.Bindings;
using UnityEngine.Bindings;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.Layout
{
	internal delegate void LayoutMeasureFunction(VisualElement ve, ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result);
}
namespace UnityEngine.UIElements.StyleSheets
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct StylePropertyValue
	{
		public StyleSheet sheet;

		public StyleValueHandle handle;
	}
}
namespace UnityEngine.UIElements
{
	public enum BindingMode
	{
		TwoWay,
		ToSource,
		ToTarget,
		ToTargetOnce
	}
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements
{
	internal interface IMouseEventInternal
	{
		IPointerEvent sourcePointerEvent { get; }

		bool recomputeTopElementUnderMouse { get; }
	}
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements
{
}
