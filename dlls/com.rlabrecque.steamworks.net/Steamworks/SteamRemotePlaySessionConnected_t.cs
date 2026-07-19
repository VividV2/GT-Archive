using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(3406)]
public struct DownloadItemResult_t
{
	public const int k_iCallback = 3406;

	public AppId_t m_unAppID;

	public PublishedFileId_t m_nPublishedFileId;

	public EResult m_eResult;
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
