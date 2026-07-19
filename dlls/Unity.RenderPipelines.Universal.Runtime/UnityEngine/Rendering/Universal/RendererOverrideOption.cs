using System;
using System;

namespace UnityEngine.Rendering.Universal
{
	[Obsolete("Renderer override is no longer used, renderers are referenced by index on the pipeline asset. #from(2023.1)")]
	public enum RendererOverrideOption
	{
		Custom,
		UsePipelineSettings
	}
}
namespace UnityEngine.Rendering.Universal
{
	[Flags]
	public enum ScriptableRenderPassInput
	{
		None = 0,
		Depth = 1,
		Normal = 2,
		Color = 4,
		Motion = 8
	}
}
