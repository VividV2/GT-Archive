using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering.RenderGraphModule
{
}
namespace UnityEngine.Rendering.RenderGraphModule
{
	[MovedFrom(true, "UnityEngine.Experimental.Rendering.RenderGraphModule", "UnityEngine.Rendering.RenderGraphModule", null)]
	public delegate void BaseRenderFunc<PassData, ContextType>(PassData data, ContextType renderGraphContext) where PassData : class, new();
}
namespace UnityEngine.Rendering
{
	internal enum PerformanceBottleneck
	{
		Indeterminate,
		PresentLimited,
		CPU,
		GPU,
		Balanced
	}
}
namespace UnityEngine.Rendering
{
}
