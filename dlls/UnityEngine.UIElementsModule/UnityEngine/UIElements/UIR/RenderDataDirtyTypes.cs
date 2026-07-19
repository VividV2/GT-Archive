using System;

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
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements.UIR
{
	[Flags]
	internal enum RenderDataDirtyTypes
	{
		None = 0,
		Transform = 1,
		ClipRectSize = 2,
		Clipping = 4,
		ClippingHierarchy = 8,
		Visuals = 0x10,
		VisualsHierarchy = 0x20,
		VisualsOpacityId = 0x40,
		Opacity = 0x80,
		OpacityHierarchy = 0x100,
		Color = 0x200,
		AllVisuals = 0x70
	}
}
