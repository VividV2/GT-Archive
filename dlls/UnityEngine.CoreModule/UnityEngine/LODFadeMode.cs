using System;

namespace UnityEngine.Rendering;

public struct BatchRendererGroupCreateInfo
{
	public BatchRendererGroup.OnPerformCulling cullingCallback;

	public BatchRendererGroup.OnFinishedCulling finishedCullingCallback;

	public IntPtr userContext;
}
namespace UnityEngine
{
	[Obsolete("See QualitySettings.names, QualitySettings.SetQualityLevel, and QualitySettings.GetQualityLevel")]
	public enum QualityLevel
	{
		Fastest,
		Fast,
		Simple,
		Good,
		Beautiful,
		Fantastic
	}
}
