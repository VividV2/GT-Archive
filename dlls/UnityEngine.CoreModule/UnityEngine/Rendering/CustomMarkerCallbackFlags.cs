using System;
using System;

namespace UnityEngine.Rendering
{
	[Flags]
	public enum CustomMarkerCallbackFlags
	{
		CustomMarkerCallbackDefault = 0,
		CustomMarkerCallbackForceInvalidateStateTracking = 4
	}
}
namespace UnityEngine.Rendering
{
	public enum VideoShadersIncludeMode
	{
		[InspectorName("Don't include")]
		Never,
		[InspectorName("Include if referenced")]
		Referenced,
		[InspectorName("Always include")]
		Always
	}
}
