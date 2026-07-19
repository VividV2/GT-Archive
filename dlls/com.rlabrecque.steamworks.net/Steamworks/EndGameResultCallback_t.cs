using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(5215)]
	public struct EndGameResultCallback_t
	{
		public const int k_iCallback = 5215;

		public EResult m_eResult;

		public ulong ullUniqueGameID;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1023)]
	public struct FileDetailsResult_t
	{
		public const int k_iCallback = 1023;

		public EResult m_eResult;

		public ulong m_ulFileSize;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 20)]
		public byte[] m_FileSHA;

		public uint m_unFlags;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(5701)]
	public struct SteamRemotePlaySessionConnected_t
	{
		public const int k_iCallback = 5701;

		public RemotePlaySessionID_t m_unSessionID;
	}
}
