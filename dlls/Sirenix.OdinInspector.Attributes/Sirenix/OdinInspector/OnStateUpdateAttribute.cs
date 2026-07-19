using System;
using System.Diagnostics;
using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector;

[DontApplyToListElements]
[AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
[Conditional("UNITY_EDITOR")]
[IncludeMyAttributes]
[HideInTables]
public sealed class OnStateUpdateAttribute(string action) : Attribute
{
	public string Action = action;
}
