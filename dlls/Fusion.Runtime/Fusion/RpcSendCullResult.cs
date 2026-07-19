namespace Fusion
{
	public enum RpcSendCullResult
	{
		NotCulled,
		NotInvokableDuringResim,
		InsufficientSourceAuthority,
		NoActiveConnections,
		TargetPlayerUnreachable,
		TargetPlayerIsLocalButRpcIsNotInvokableLocally,
		PayloadSizeExceeded
	}
}
namespace Fusion
{
}
