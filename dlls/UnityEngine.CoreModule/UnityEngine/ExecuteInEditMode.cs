using System;
using System.Runtime.InteropServices;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[UsedByNativeCode]
	public sealed class ExecuteInEditMode : Attribute
	{
	}
}
namespace UnityEngine
{
	[StructLayout(LayoutKind.Sequential)]
	[RequiredByNativeCode]
	[NativeClass(null)]
	[ExcludeFromObjectFactory]
	internal class FailedToLoadScriptObject : Object
	{
		private FailedToLoadScriptObject()
		{
		}
	}
}
namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class DelayedAttribute : PropertyAttribute
	{
	}
}
