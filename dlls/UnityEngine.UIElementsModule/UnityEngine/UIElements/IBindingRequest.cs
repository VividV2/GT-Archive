namespace UnityEngine.UIElements
{
	internal interface IBindingRequest
	{
		void Bind(VisualElement element);

		void Release();
	}
}
namespace UnityEngine.UIElements
{
	internal delegate void HierarchyEvent(VisualElement ve, HierarchyChangeType changeType, System.Collections.Generic.IReadOnlyList<VisualElement> additionalContext = null);
}
namespace UnityEngine.UIElements
{
}
