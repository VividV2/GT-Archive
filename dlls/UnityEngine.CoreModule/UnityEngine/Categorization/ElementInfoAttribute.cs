using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine;

[NativeHeader("Runtime/Export/Scripting/ScriptingRuntime.h")]
[VisibleToOtherModules]
internal class ScriptingRuntime
{
	[MethodImpl(MethodImplOptions.InternalCall)]
	public static extern string[] GetAllUserAssemblies();
}
namespace UnityEngine.Serialization
{
}
namespace UnityEngine.Rendering
{
}
