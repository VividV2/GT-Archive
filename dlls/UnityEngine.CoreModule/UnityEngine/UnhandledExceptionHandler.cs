using System;
using System;
using System;
using System;

namespace UnityEngine;

namespace UnityEngine.Rendering
{
	[Flags]
	public enum UISubset
	{
		UIToolkit_UGUI = 1,
		LowLevel = 2,
		All = -1
	}
}
namespace Unity.Profiling.Memory
{
	[Flags]
	public enum CaptureFlags : uint
	{
		ManagedObjects = 1u,
		NativeObjects = 2u,
		NativeAllocations = 4u,
		NativeAllocationSites = 8u,
		NativeStackTraces = 0x10u
	}
}
namespace JetBrains.Annotations
{
}
