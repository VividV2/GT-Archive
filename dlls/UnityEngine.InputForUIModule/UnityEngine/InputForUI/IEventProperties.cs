using Unity.IntegerTime;
using UnityEngine.Bindings;

namespace UnityEngine.InputForUI
{
}
namespace UnityEngine.InputForUI
{
	[VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
	internal enum EventSource
	{
		Unspecified,
		Keyboard,
		Gamepad,
		Mouse,
		Pen,
		Touch,
		TrackedDevice
	}
}
namespace UnityEngine.InputForUI
{
	internal interface IEventProperties
	{
		DiscreteTime timestamp { get; }

		EventSource eventSource { get; }

		uint playerId { get; }

		EventModifiers eventModifiers { get; }
	}
}
