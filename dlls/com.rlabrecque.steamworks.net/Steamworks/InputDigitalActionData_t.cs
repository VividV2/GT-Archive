using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	public struct SteamNetConnectionRealTimeLaneStatus_t
	{
		public int m_cbPendingUnreliable;

		public int m_cbPendingReliable;

		public int m_cbSentUnackedReliable;

		public int _reservePad1;

		public SteamNetworkingMicroseconds m_usecQueueTime;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public uint[] reserved;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct InputDigitalActionData_t
	{
		public byte bState;

		public byte bActive;
	}
}
namespace Steamworks
{
}
