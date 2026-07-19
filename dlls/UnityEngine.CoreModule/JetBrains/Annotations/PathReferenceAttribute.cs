using System;
using UnityEngine.Scripting;
using UnityEngine.Scripting;

namespace JetBrains.Annotations
{
	[AttributeUsage(AttributeTargets.Parameter)]
	public sealed class PathReferenceAttribute : Attribute
	{
		[CanBeNull]
		public string BasePath { get; }

		public PathReferenceAttribute()
		{
		}

		public PathReferenceAttribute([NotNull][PathReference] string basePath)
		{
			BasePath = basePath;
		}
	}
}
namespace Unity.IO.LowLevel.Unsafe
{
	[RequiredByNativeCode]
	public enum Priority
	{
		PriorityLow,
		PriorityHigh
	}
}
