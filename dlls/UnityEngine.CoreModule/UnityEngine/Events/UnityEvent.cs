using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine.Events;

[Serializable]
public class UnityEvent<T0> : UnityEventBase
{
	private object[] m_InvokeArray = null;

	[RequiredByNativeCode]
	public UnityEvent()
	{
	}

	public void AddListener(UnityAction<T0> call)
	{
		AddCall(GetDelegate(call));
	}

	public void RemoveListener(UnityAction<T0> call)
	{
		RemoveListener(call.Target, call.Method);
	}

	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
	{
		return UnityEventBase.GetValidMethodInfo(targetObjType, name, new Type[1] { typeof(T0) });
	}

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
	{
		return new InvokableCall<T0>(target, theFunction);
	}

	private static BaseInvokableCall GetDelegate(UnityAction<T0> action)
	{
		return new InvokableCall<T0>(action);
	}

	public void Invoke(T0 arg0)
	{
		List<BaseInvokableCall> list = PrepareInvoke();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] is InvokableCall<T0> invokableCall)
			{
				invokableCall.Invoke(arg0);
				continue;
			}
			if (list[i] is InvokableCall invokableCall2)
			{
				invokableCall2.Invoke();
				continue;
			}
			BaseInvokableCall baseInvokableCall = list[i];
			if (m_InvokeArray == null)
			{
				m_InvokeArray = new object[1];
			}
			m_InvokeArray[0] = arg0;
			baseInvokableCall.Invoke(m_InvokeArray);
		}
	}
}
