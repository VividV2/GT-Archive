namespace UnityEngine.UIElements.Layout
{
	internal enum LayoutUnit
	{
		Undefined,
		Point,
		Percent,
		Auto
	}
}
namespace UnityEngine.UIElements.StyleSheets
{
}
namespace UnityEngine.UIElements.Layout
{
	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	internal delegate void InvokeMeasureFunctionDelegate(ref LayoutNode node, float width, LayoutMeasureMode widthMode, float height, LayoutMeasureMode heightMode, ref IntPtr exception, out LayoutSize result);
}
