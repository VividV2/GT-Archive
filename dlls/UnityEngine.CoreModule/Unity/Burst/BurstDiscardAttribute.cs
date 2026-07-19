using System;
using System;

namespace Unity.Scripting.LifecycleManagement
{
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
	internal sealed class AfterCodeLoadedAttribute : LifecycleAttributeBase
	{
	}
}
namespace Unity.Burst
{
	[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
	public class BurstDiscardAttribute : Attribute
	{
	}
}
