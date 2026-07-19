using System;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[Flags]
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal enum PseudoStates
	{
		Active = 1,
		Hover = 2,
		Checked = 8,
		Disabled = 0x20,
		Focus = 0x40,
		Root = 0x80
	}
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements
{
	internal enum EventCategory
	{
		Default,
		Pointer,
		PointerMove,
		PointerDown,
		EnterLeave,
		EnterLeaveWindow,
		Keyboard,
		Geometry,
		Style,
		ChangeValue,
		Bind,
		Focus,
		ChangePanel,
		StyleTransition,
		Navigation,
		Command,
		Tooltip,
		DragAndDrop,
		IMGUI
	}
}
