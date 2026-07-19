using System;

namespace Unity.Scripting.LifecycleManagement
{
}
namespace Unity.Burst
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public class BurstDiscardAttribute : Attribute
	{
	}
}
