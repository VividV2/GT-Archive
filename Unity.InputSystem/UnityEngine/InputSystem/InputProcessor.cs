using System;
using UnityEngine.InputSystem.Utilities;

namespace UnityEngine.InputSystem;

public abstract class InputProcessor
{
	public enum CachingPolicy
	{
		CacheResult,
		EvaluateOnEveryRead
	}

	internal static TypeTable s_Processors;

	public virtual CachingPolicy cachingPolicy => CachingPolicy.CacheResult;

	public abstract object ProcessAsObject(object value, InputControl control);

	public unsafe abstract void Process(void* buffer, int bufferSize, InputControl control);

	internal static Type GetValueTypeFromType(Type processorType)
	{
		if (processorType == null)
		{
			throw new ArgumentNullException("processorType");
		}
		return TypeHelpers.GetGenericTypeArgumentFromHierarchy(processorType, typeof(InputProcessor<>), 0);
	}
}
