using System.Runtime.CompilerServices;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	public enum ReflectionProbeMode
	{
		Baked,
		Realtime,
		Custom
	}
}
namespace UnityEngine.Internal
{
	[ExcludeFromDocs]
	[UnityEngine.Bindings.NativeHeader("Runtime/GfxDevice/HDROutputSettings.h")]
	internal static class InternalHDROutputFaking
	{
		[System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.InternalCall)]
		[UnityEngine.Bindings.FreeFunction("HDROutputSettingsBindings::SetFakeHDROutputEnabled")]
		[ExcludeFromDocs]
		internal static extern void SetEnabled(bool enabled);
	}
}
namespace UnityEngine.Rendering
{
}
