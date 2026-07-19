using System;
using System.Diagnostics;
using System;
using System.Diagnostics;

namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
	[Conditional("UNITY_EDITOR")]
	public class HideReferenceObjectPickerAttribute : Attribute
	{
	}
}
namespace Sirenix.OdinInspector
{
	[AttributeUsage(AttributeTargets.All)]
	[Conditional("UNITY_EDITOR")]
	public class HideInAttribute : Attribute
	{
		public PrefabKind PrefabKind;

		public HideInAttribute(PrefabKind prefabKind)
		{
			PrefabKind = prefabKind;
		}
	}
}
