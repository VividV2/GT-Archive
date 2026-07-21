using ExitGames.Client.Photon;

namespace Fusion.Photon.Realtime;

internal enum JoinType
{
	CreateRoom,
	JoinRoom,
	JoinRandomRoom,
	JoinRandomOrCreateRoom,
	JoinOrCreateRoom
}
namespace Fusion.Photon.Realtime
{
	internal interface IWebRpcCallback
	{
		void OnWebRpcResponse(OperationResponse response);
	}
}
