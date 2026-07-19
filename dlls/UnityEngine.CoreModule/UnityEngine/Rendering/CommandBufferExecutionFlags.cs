using UnityEngine.Bindings;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum CullMode
	{
		Off,
		Front,
		Back
	}
}
namespace UnityEngine.Rendering
{
	public enum CommandBufferExecutionFlags
	{
		None = 0,
		AsyncCompute = 2
	}
}
