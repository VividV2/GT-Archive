using System;
using System.Runtime.InteropServices;
using System;

namespace UnityEngine.Analytics
{
	[Flags]
	public enum SendEventOptions
	{
		kAppendNone = 0,
		kAppendBuildGuid = 1,
		kAppendBuildTarget = 2
	}
}
namespace UnityEngine.Search
{
}
namespace UnityEngine.Rendering
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	[Obsolete("GPUFence has been deprecated. Use GraphicsFence instead (UnityUpgradable) -> GraphicsFence", false)]
	public struct GPUFence
	{
		public bool passed => true;
	}
}
