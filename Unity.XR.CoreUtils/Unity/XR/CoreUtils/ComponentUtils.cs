using System.Collections.Generic;
using UnityEngine;

namespace Unity.XR.CoreUtils;

public static class ComponentUtils<T>
{
	private static readonly List<T> k_RetrievalList = new List<T>();

	public static T GetComponent(GameObject gameObject)
	{
		T result = default(T);
		gameObject.GetComponents(k_RetrievalList);
		if (k_RetrievalList.Count > 0)
		{
			return k_RetrievalList[0];
		}
		return result;
	}

	public static T GetComponentInChildren(GameObject gameObject)
	{
		T result = default(T);
		gameObject.GetComponentsInChildren(k_RetrievalList);
		if (k_RetrievalList.Count > 0)
		{
			return k_RetrievalList[0];
		}
		return result;
	}
}
