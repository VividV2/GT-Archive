using System.Runtime.InteropServices;

namespace System.Net.NetworkInformation
{
	[StructLayout(LayoutKind.Sequential)]
	internal class Win32_IP_PER_ADAPTER_INFO
	{
		public uint AutoconfigEnabled;

		public uint AutoconfigActive;

		public IntPtr CurrentDnsServer;

		public Win32_IP_ADDR_STRING DnsServerList;
	}
}
namespace System.Collections.Specialized
{
}
namespace System.ComponentModel.Design.Serialization
{
}
namespace System.Net.Http
{
}
namespace System.IO
{
}
