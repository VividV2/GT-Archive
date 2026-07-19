using UnityEngine.Bindings;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal enum OverflowInternal
	{
		Visible,
		Hidden,
		Scroll
	}
}
namespace UnityEngine.UIElements
{
	internal interface IPointerCaptureEventInternal
	{
		int pointerId { get; }
	}
}
