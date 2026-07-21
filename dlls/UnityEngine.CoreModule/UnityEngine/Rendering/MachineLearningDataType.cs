using System;
using System;

namespace UnityEngine.Rendering
{
	[Flags]
	public enum MeshUpdateFlags
	{
		Default = 0,
		DontValidateIndices = 1,
		DontResetBoneBounds = 2,
		DontNotifyMeshUsers = 4,
		DontRecalculateBounds = 8,
		DontValidateLodRanges = 0x10
	}
}
namespace UnityEngine
{
	public enum TransparencySortMode
	{
		Default,
		Perspective,
		Orthographic,
		CustomAxis
	}
}
namespace UnityEngine.Rendering
{
	[UnityEngine.Bindings.NativeHeader("Runtime/Export/Graphics/MachineLearning.bindings.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/MachineLearning/MachineLearningTensor.h")]
	public enum MachineLearningDataType
	{
		Unknown,
		Float32,
		Float16,
		UInt32,
		UInt16,
		UInt8,
		Int32,
		Int16,
		Int8,
		Float64,
		UInt64,
		Int64
	}
}
