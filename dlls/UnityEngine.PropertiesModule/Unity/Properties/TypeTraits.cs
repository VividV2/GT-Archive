using System;

namespace Unity.Properties;

public static class TypeTraits
{
	public static bool IsContainer(Type type)
	{
		if (null == type)
		{
			throw new ArgumentNullException("type");
		}
		return !type.IsPrimitive && !type.IsPointer && !type.IsEnum && !(type == typeof(string));
	}
}
