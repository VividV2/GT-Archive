using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class RecreatePipelineOnChangeAttribute : Attribute
	{
	}
}
namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Shaders/Keywords/KeywordSpaceScriptBindings.h")]
	public enum ShaderKeywordType
	{
		None = 0,
		BuiltinDefault = 2,
		[Obsolete("Shader keyword type BuiltinExtra is no longer used. Use BuiltinDefault instead. (UnityUpgradable) -> BuiltinDefault")]
		BuiltinExtra = 6,
		[Obsolete("Shader keyword type BuiltinAutoStripped is no longer used. Use BuiltinDefault instead. (UnityUpgradable) -> BuiltinDefault")]
		BuiltinAutoStripped = 10,
		UserDefined = 16,
		Plugin = 32
	}
}
namespace UnityEngine.Rendering
{
}
