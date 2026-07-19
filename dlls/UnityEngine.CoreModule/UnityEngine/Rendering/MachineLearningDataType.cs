using System.Collections.Generic;
using UnityEngine.Bindings;
using System.Collections.Generic;

namespace UnityEngine.Rendering
{
	internal delegate void GPUDrivenRendererDataNativeCallback(in GPUDrivenRendererGroupDataNative rendererDataNative, List<Mesh> meshes, List<Material> materials, GPUDrivenRendererDataCallback callback);
}
namespace UnityEngine.Rendering
{
	[NativeHeader("Runtime/Export/Graphics/MachineLearning.bindings.h")]
	[NativeHeader("Runtime/Graphics/MachineLearning/MachineLearningTensor.h")]
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
