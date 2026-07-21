using System;
using System.Diagnostics;
using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector;

[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
[Conditional("UNITY_EDITOR")]
public sealed class ToggleAttribute(string toggleMemberName) : Attribute
{
	public string ToggleMemberName = toggleMemberName;

	[LabelWidth(160f)]
	public bool CollapseOthersOnExpand = true;
}
