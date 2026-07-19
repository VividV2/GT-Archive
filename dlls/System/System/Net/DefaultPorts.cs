namespace System.Net
{
	internal enum DefaultPorts
	{
		DEFAULT_FTP_PORT = 21,
		DEFAULT_GOPHER_PORT = 70,
		DEFAULT_HTTP_PORT = 80,
		DEFAULT_HTTPS_PORT = 443,
		DEFAULT_NNTP_PORT = 119,
		DEFAULT_SMTP_PORT = 25,
		DEFAULT_TELNET_PORT = 23
	}
}
namespace System.Net.NetworkInformation
{
	internal struct Win32_SOCKADDR
	{
		public ushort AddressFamily;

		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.ByValArray, SizeConst = 28)]
		public byte[] AddressData;
	}
}
