using System;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine.Scripting;

namespace UnityEngine.Events;

[Serializable]
public class UnityEvent : UnityEventBase
{
	private object[] m_InvokeArray = null;

	[RequiredByNativeCode]
	public UnityEvent()
	{
	}

	public void AddListener(UnityAction call)
	{
		AddCall(GetDelegate(call));
	}

	public void RemoveListener(UnityAction call)
	{
		RemoveListener(call.Target, call.Method);
	}

	protected override MethodInfo FindMethod_Impl(string name, Type targetObjType)
	{
		return UnityEventBase.GetValidMethodInfo(targetObjType, name, new Type[0]);
	}

	internal override BaseInvokableCall GetDelegate(object target, MethodInfo theFunction)
	{
		return new InvokableCall(target, theFunction);
	}

	private static BaseInvokableCall GetDelegate(UnityAction action)
	{
		return new InvokableCall(action);
	}

	public void Invoke()
	{
		List<BaseInvokableCall> list = PrepareInvoke();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] is InvokableCall invokableCall)
			{
				invokableCall.Invoke();
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
				m_InvokeArray = new object[0];
			}
			baseInvokableCall.Invoke(m_InvokeArray);
		}
	}
}
