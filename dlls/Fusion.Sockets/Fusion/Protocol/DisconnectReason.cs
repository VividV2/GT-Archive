namespace Microsoft.CodeAnalysis
{
}
namespace Fusion.Protocol
{
}
namespace Fusion.Protocol
{
	public enum DisconnectReason : byte
	{
		None,
		ServerLogic,
		InvalidEventCode,
		InvalidJoinMsgType,
		InvalidJoinGameMode,
		IncompatibleConfiguration,
		ServerAlreadyInRoom,
		Error
	}
}
