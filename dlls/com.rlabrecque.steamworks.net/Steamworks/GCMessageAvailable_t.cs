using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(5701)]
public struct SteamRemotePlaySessionConnected_t
{
	public const int k_iCallback = 5701;

	public RemotePlaySessionID_t m_unSessionID;
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1701)]
	public struct GCMessageAvailable_t
	{
		public const int k_iCallback = 1701;

		public uint m_nMessageSize;
	}
}
