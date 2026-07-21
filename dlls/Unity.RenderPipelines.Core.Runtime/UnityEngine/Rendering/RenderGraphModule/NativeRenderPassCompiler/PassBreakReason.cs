namespace UnityEngine.Rendering.RenderGraphModule.NativeRenderPassCompiler
{
	internal enum PassBreakReason
	{
		NotOptimized,
		TargetSizeMismatch,
		NextPassReadsTexture,
		NextPassTargetsTexture,
		NonRasterPass,
		DifferentDepthTextures,
		AttachmentLimitReached,
		SubPassLimitReached,
		EndOfGraph,
		FRStateMismatch,
		DifferentShadingRateImages,
		DifferentShadingRateStates,
		PassMergingDisabled,
		Merged,
		Count
	}
}
namespace UnityEngine.Rendering
{
}
namespace UnityEngine.Rendering
{
	public interface ICameraHistoryReadAccess
	{
		public delegate void HistoryRequestDelegate(IPerFrameHistoryAccessTracker historyAccess);

		event HistoryRequestDelegate OnGatherHistoryRequests;

		Type GetHistoryForRead<Type>() where Type : ContextItem;
	}
}
namespace UnityEngine.Rendering.RenderGraphModule
{
}
