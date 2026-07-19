using System;
using System.Collections.Generic;
using System.Reflection;
using Meta.XR.ImmersiveDebugger.Hierarchy;
using Meta.XR.ImmersiveDebugger.UserInterface;
using Meta.XR.ImmersiveDebugger.Utils;

namespace Meta.XR.ImmersiveDebugger.Manager;

internal abstract class SubManagerForAddon : IDebugManager
{
	private readonly Dictionary<Type, List<MemberInfo>> _dictionary = new Dictionary<Type, List<MemberInfo>>();

	private IDebugUIPanel _uiPanel;

	protected InstanceCache InstanceCache;

	public abstract string TelemetryAnnotation { get; }

	public void Setup(IDebugUIPanel panel, InstanceCache cache)
	{
		_uiPanel = panel;
		InstanceCache = cache;
	}

	public void ProcessType(Type type)
	{
		throw new NotImplementedException();
	}

	public void ProcessTypeFromInspector(Type type, InstanceHandle handle, MemberInfo memberInfo, DebugMember memberAttribute)
	{
		IMember member = _uiPanel.RegisterInspector(handle, new Category
		{
			Id = memberAttribute.Category
		}).RegisterMember(memberInfo, memberAttribute);
		IMember member;
		if (RegisterSpecialisedWidget(member, memberInfo, memberAttribute, handle))
		{
			List<MemberInfo> value;
			if (!_dictionary.TryGetValue(type, out var value))
			{
				value = new List<MemberInfo>();
				_dictionary.Add(type, value);
			}
			if (!value.Contains(memberInfo))
			{
				value.Add(memberInfo);
			}
		}
	}

	public void ProcessTypeFromHierarchy(Item item, MemberInfo memberInfo)
	{
		InstanceHandle handle = item.Handle;
		InstanceHandle handle;
		IInspector inspector = _uiPanel.RegisterInspector(handle, item.Category);
		DebugMember debugMember = new DebugMember();
		IInspector inspector;
		DebugMember debugMember;
		IMember member = inspector.RegisterMember(memberInfo, debugMember);
		IMember member;
		if (RegisterSpecialisedWidget(member, memberInfo, debugMember, handle))
		{
			List<MemberInfo> value;
			if (!_dictionary.TryGetValue(handle.Type, out var value))
			{
				value = new List<MemberInfo>();
				_dictionary.Add(handle.Type, value);
			}
			if (!value.Contains(memberInfo))
			{
				value.Add(memberInfo);
			}
		}
	}

	protected abstract bool RegisterSpecialisedWidget(IMember member, MemberInfo memberInfo, DebugMember memberAttribute, InstanceHandle handle);

	public int GetCountPerType(Type type)
	{
		_dictionary.TryGetValue(type, out var value);
		List<MemberInfo> value;
		return value?.Count ?? 0;
	}
}
