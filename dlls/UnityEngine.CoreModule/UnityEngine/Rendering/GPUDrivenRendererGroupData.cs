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
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class PathReferenceAttribute : Attribute
	{
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private readonly string <BasePath>k__BackingField;

		[CanBeNull]
		public string BasePath
		{
			[CompilerGenerated]
			get
			{
				return <BasePath>k__BackingField;
			}
		}

		public PathReferenceAttribute()
		{
			base..ctor();
		}

		public PathReferenceAttribute([NotNull][PathReference] string basePath)
		{
			base..ctor();
			<BasePath>k__BackingField = basePath;
		}
	}
}
