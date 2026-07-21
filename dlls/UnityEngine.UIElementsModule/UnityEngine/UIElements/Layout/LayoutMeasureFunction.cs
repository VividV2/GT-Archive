namespace UnityEngine.UIElements.Layout
{
	internal delegate void LayoutMeasureFunction(VisualElement ve, ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, out LayoutSize result);
}
namespace UnityEngine.UIElements
{
	internal interface ITextElement
	{
		string text { get; set; }
	}
}
