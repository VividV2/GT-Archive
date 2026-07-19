namespace UnityEngine.UIElements;

public interface IMouseCaptureEvent
{
}
namespace UnityEngine.UIElements
{
	public enum Align
	{
		Auto,
		FlexStart,
		Center,
		FlexEnd,
		Stretch
	}
}
namespace UnityEngine.UIElements
{
	public interface IDebugPanelChangeReceiver
	{
		void OnVisualElementChange(VisualElement element, VersionChangeType changeType);
	}
}
