namespace System.Net.Sockets;

/// <summary>The type of asynchronous socket operation most recently performed with this context object.</summary>
public enum SocketAsyncOperation
{
	/// <summary>None of the socket operations.</summary>
	None,
	/// <summary>A socket Accept operation.</summary>
	Accept,
	/// <summary>A socket Connect operation.</summary>
	Connect,
	Disconnect,
	Receive,
	ReceiveFrom,
	ReceiveMessageFrom,
	Send,
	SendPackets,
	SendTo
}
