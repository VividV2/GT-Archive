using System;

namespace Valve.Newtonsoft.Json
{
	[AttributeUsage(AttributeTargets.Constructor, AllowMultiple = false)]
	public sealed class JsonConstructorAttribute : Attribute
	{
	}
}
namespace Valve.Newtonsoft.Json
{
	internal enum JsonContainerType
	{
		None,
		Object,
		Array,
		Constructor
	}
}
