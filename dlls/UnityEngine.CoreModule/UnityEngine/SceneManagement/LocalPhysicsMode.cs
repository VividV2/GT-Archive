using System;
using System;

namespace UnityEngine.SceneManagement
{
	[Flags]
	public enum LocalPhysicsMode
	{
		None = 0,
		Physics2D = 1,
		Physics3D = 2
	}
}
namespace UnityEngine.Rendering
{
	[UnityEngine.Bindings.NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum StencilOp
	{
		Keep,
		Zero,
		Replace,
		IncrementSaturate,
		DecrementSaturate,
		Invert,
		IncrementWrap,
		DecrementWrap
	}
}
