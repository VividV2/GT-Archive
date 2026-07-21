using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using System;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	[UsedByNativeCode]
	[NativeHeader("Modules/VFX/Public/ScriptBindings/VisualEffectAssetBindings.h")]
	[NativeHeader("Modules/VFX/Public/VisualEffectAsset.h")]
	[NativeHeader("VFXScriptingClasses.h")]
	public abstract class VisualEffectObject : Object
	{
	}
}
namespace UnityEngine.VFX
{
	[UsedByNativeCode]
	public struct VFXExposedProperty
	{
		public string name;

		public Type type;
	}
}
namespace UnityEngine.VFX
{
}
