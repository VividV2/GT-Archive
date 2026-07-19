using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(5303)]
	public struct ReservationNotificationCallback_t
	{
		public const int k_iCallback = 5303;

		public PartyBeaconID_t m_ulBeaconID;

		public CSteamID m_steamIDJoiner;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3416)]
	public struct GetAppDependenciesResult_t
	{
		public const int k_iCallback = 3416;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
		public AppId_t[] m_rgAppIDs;

		public uint m_nNumAppDependencies;

		public uint m_nTotalNumAppDependencies;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1331)]
	public struct RemoteStorageFileWriteAsyncComplete_t
	{
		public const int k_iCallback = 1331;

		public EResult m_eResult;
	}
}
