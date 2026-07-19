using System;
using System;

namespace UnityEngine
{
}
namespace UnityEngine.Rendering
{
	[Flags]
	public enum CullingOptions
	{
		None = 0,
		ForceEvenIfCameraIsNotActive = 1,
		OcclusionCull = 2,
		NeedsLighting = 4,
		NeedsReflectionProbes = 8,
		Stereo = 0x10,
		DisablePerObjectCulling = 0x20,
		ShadowCasters = 0x40
	}
}
namespace UnityEngine.Pool
{
}
namespace UnityEngine.Events
{
	public delegate void UnityAction<T0, T1, T2, T3>(T0 arg0, T1 arg1, T2 arg2, T3 arg3);
}
namespace UnityEngine
{
}
