namespace Fusion
{
	public enum RpcChannel
	{
		Reliable,
		Unreliable
	}
}
namespace Fusion
{
	public unsafe delegate void RpcStaticInvokeDelegate(NetworkRunner runner, SimulationMessage* message);
}
