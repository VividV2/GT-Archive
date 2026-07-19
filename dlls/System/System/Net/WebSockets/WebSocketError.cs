using System.Runtime.InteropServices;

namespace System.Net.WebSockets
{
	/// <summary>Contains the list of possible WebSocket errors.</summary>
	public enum WebSocketError
	{
		/// <summary>Indicates that there was no native error information for the exception.</summary>
		Success,
		/// <summary>Indicates that a WebSocket frame with an unknown opcode was received.</summary>
		InvalidMessageType,
		/// <summary>Indicates a general error.</summary>
		Faulted,
		/// <summary>Indicates that an unknown native error occurred.</summary>
		NativeError,
		/// <summary>Indicates that the incoming request was not a valid websocket request.</summary>
		NotAWebSocket,
		/// <summary>Indicates that the client requested an unsupported version of the WebSocket protocol.</summary>
		UnsupportedVersion,
		/// <summary>Indicates that the client requested an unsupported WebSocket subprotocol.</summary>
		UnsupportedProtocol,
		/// <summary>Indicates an error occurred when parsing the HTTP headers during the opening handshake.</summary>
		HeaderError,
		/// <summary>Indicates that the connection was terminated unexpectedly.</summary>
		ConnectionClosedPrematurely,
		/// <summary>Indicates the WebSocket is an invalid state for the given operation (such as being closed or aborted).</summary>
		InvalidState
	}
}
namespace System.Net.NetworkInformation
{
	internal struct Win32_IP_ADAPTER_INFO
	{
		private const int MAX_ADAPTER_NAME_LENGTH = 256;

		private const int MAX_ADAPTER_DESCRIPTION_LENGTH = 128;

		private const int MAX_ADAPTER_ADDRESS_LENGTH = 8;

		public IntPtr Next;

		public int ComboIndex;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string AdapterName;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 132)]
		public string Description;

		public uint AddressLength;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
		public byte[] Address;

		public uint Index;

		public uint Type;

		public uint DhcpEnabled;

		public IntPtr CurrentIpAddress;

		public Win32_IP_ADDR_STRING IpAddressList;

		public Win32_IP_ADDR_STRING GatewayList;

		public Win32_IP_ADDR_STRING DhcpServer;

		public bool HaveWins;

		public Win32_IP_ADDR_STRING PrimaryWinsServer;

		public Win32_IP_ADDR_STRING SecondaryWinsServer;

		public long LeaseObtained;

		public long LeaseExpires;
	}
}
namespace System.Net.Security
{
}
