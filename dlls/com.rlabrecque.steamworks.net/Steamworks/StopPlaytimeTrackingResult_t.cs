using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3411)]
	public struct StopPlaytimeTrackingResult_t
	{
		public const int k_iCallback = 3411;

		public EResult m_eResult;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(113)]
	public struct ClientGameServerDeny_t
	{
		public const int k_iCallback = 113;

		public uint m_uAppID;

		public uint m_unGameServerIP;

		public ushort m_usGameServerPort;

		public ushort m_bSecure;

		public uint m_uReason;
	}
}
