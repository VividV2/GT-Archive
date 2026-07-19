using System;
using Unity.Collections;
using System;
using Unity.Collections;

namespace UnityEngine.Rendering
{
	public struct BatchCullingOutput
	{
		public NativeArray<BatchCullingOutputDrawCommands> drawCommands;

		public NativeArray<IntPtr> customCullingResult;
	}
}
namespace UnityEngine.Rendering
{
	[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/MachineLearning/MachineLearningOperator.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/MachineLearning/MachineLearningContext.h")]
	[UnityEngine.Bindings.NativeHeader("Runtime/Graphics/MachineLearning/MachineLearningOperatorAttributes.h")]
	public enum MachineLearningOperatorType : uint
	{
		None,
		Identity,
		Gemm,
		Conv,
		ReLU,
		ReduceMax,
		ReduceMean,
		ReduceMin,
		ReduceProd,
		ReduceSum,
		ReduceSumSquare,
		ReduceL1,
		ReduceL2,
		ReduceLogSum,
		ReduceLogSumExp
	}
}
