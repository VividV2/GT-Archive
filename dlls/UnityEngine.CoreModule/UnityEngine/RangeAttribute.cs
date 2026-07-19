using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;
using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;
using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
	public sealed class RangeAttribute : PropertyAttribute
	{
		public readonly float min;

		public readonly float max;

		public RangeAttribute(float min, float max)
		{
			this.min = min;
			this.max = max;
		}
	}
}
namespace UnityEngine.LowLevel
{
	[NativeType(Header = "Runtime/Misc/PlayerLoop.h")]
	[MovedFrom("UnityEngine.Experimental.LowLevel")]
	[RequiredByNativeCode]
	internal struct PlayerLoopSystemInternal
	{
		public Type type;

		public PlayerLoopSystem.UpdateFunction updateDelegate;

		public IntPtr updateFunction;

		public IntPtr loopConditionFunction;

		public int numSubSystems;
	}
}
namespace UnityEngine.Device
{
}
