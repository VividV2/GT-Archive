using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;
using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Internal
{
	[ExcludeFromDocs]
	[NativeHeader("Runtime/GfxDevice/HDROutputSettings.h")]
	internal static class InternalHDROutputFaking
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		[FreeFunction("HDROutputSettingsBindings::SetFakeHDROutputEnabled")]
		[ExcludeFromDocs]
		internal static extern void SetEnabled(bool enabled);
	}
}
namespace UnityEngine.TestTools
{
	[NativeType(CodegenOptions.Custom, "ManagedCoveredSequencePoint", Header = "Runtime/Scripting/ScriptingCoverage.bindings.h")]
	public struct CoveredSequencePoint
	{
		public System.Reflection.MethodBase method;

		public uint ilOffset;

		public uint hitCount;

		public string filename;

		public uint line;

		public uint column;
	}
}
namespace UnityEngine.Analytics
{
}
namespace UnityEngine.Playables
{
}
