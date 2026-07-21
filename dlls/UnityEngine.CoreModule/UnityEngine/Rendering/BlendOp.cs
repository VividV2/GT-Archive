using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum BlendOp
	{
		Add,
		Subtract,
		ReverseSubtract,
		Min,
		Max,
		LogicalClear,
		LogicalSet,
		LogicalCopy,
		LogicalCopyInverted,
		LogicalNoop,
		LogicalInvert,
		LogicalAnd,
		LogicalNand,
		LogicalOr,
		LogicalNor,
		LogicalXor,
		LogicalEquivalence,
		LogicalAndReverse,
		LogicalAndInverted,
		LogicalOrReverse,
		LogicalOrInverted,
		Multiply,
		Screen,
		Overlay,
		Darken,
		Lighten,
		ColorDodge,
		ColorBurn,
		HardLight,
		SoftLight,
		Difference,
		Exclusion,
		HSLHue,
		HSLSaturation,
		HSLColor,
		HSLLuminosity
	}
}
namespace UnityEngine
{
}
namespace UnityEngine
{
	public enum HDRDisplayBitDepth
	{
		BitDepth10,
		BitDepth16
	}
}
namespace UnityEngine.Rendering
{
	[Flags]
	public enum SortingCriteria
	{
		None = 0,
		SortingLayer = 1,
		RenderQueue = 2,
		BackToFront = 4,
		QuantizedFrontToBack = 8,
		OptimizeStateChanges = 0x10,
		CanvasOrder = 0x20,
		RendererPriority = 0x40,
		CommonOpaque = 0x3B,
		CommonTransparent = 0x17
	}
}
