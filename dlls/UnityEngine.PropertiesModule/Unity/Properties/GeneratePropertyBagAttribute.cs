using System;
using System;

namespace Unity.Properties
{
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, Inherited = false)]
	public class GeneratePropertyBagAttribute : Attribute
	{
	}
}
namespace Unity.Properties
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DontCreatePropertyAttribute : Attribute
	{
	}
}
namespace Unity.Properties
{
}
