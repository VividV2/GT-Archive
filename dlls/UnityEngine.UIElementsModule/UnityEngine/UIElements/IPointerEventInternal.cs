namespace UnityEngine.UIElements
{
	internal interface IPointerEventInternal
	{
		IMouseEvent compatibilityMouseEvent { get; }

		int displayIndex { get; }

		bool recomputeTopElementUnderPointer { get; }
	}
}
namespace UnityEngine.UIElements
{
}
