using System.Runtime.InteropServices;

namespace Fusion.Sockets
{
	[StructLayout(LayoutKind.Explicit)]
	internal struct NetUnreliableHeader
	{
		public const int SIZE = 1;

		public const int SIZE_IN_BITS = 8;

		[FieldOffset(0)]
		public NetPacketType PacketType;

		public static NetUnreliableHeader Create()
		{
			NetUnreliableHeader result = default(NetUnreliableHeader);
			result.PacketType = NetPacketType.UnreliableData;
			return result;
		}
	}
}
namespace Fusion.Sockets
{
	public interface INetPeerGroupCallbacks
	{
		unsafe void OnConnected(NetConnection* connection);

		unsafe void OnDisconnected(NetConnection* connection, NetDisconnectReason reason);

		unsafe void OnUnreliableData(NetConnection* connection, NetBitBuffer* buffer);

		unsafe void OnUnconnectedData(NetBitBuffer* buffer);

		unsafe void OnNotifyData(NetConnection* connection, NetBitBuffer* buffer);

		unsafe void OnNotifyLost(NetConnection* connection, ref NetSendEnvelope envelope);

		unsafe void OnNotifyDelivered(NetConnection* connection, ref NetSendEnvelope envelope);

		void OnNotifyDispose(ref NetSendEnvelope envelope);

		unsafe void OnReliableData(NetConnection* connection, ReliableId id, byte* data);

		OnConnectionRequestReply OnConnectionRequest(NetAddress remoteAddress, byte[] token, byte[] uniqueId);

		void OnConnectionFailed(NetAddress address, NetConnectFailedReason reason);

		unsafe void OnConnectionAttempt(NetConnection* connection, int attempts, int totalConnectAttempts);
	}
}
namespace Fusion.Sockets
{
}
namespace Fusion.Sockets
{
}
namespace Fusion.Sockets
{
}
namespace Fusion.Sockets
{
}
namespace Fusion.Sockets.Stun
{
}
