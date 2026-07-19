using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1329)]
	public struct RemoteStoragePublishFileProgress_t
	{
		public const int k_iCallback = 1329;

		public double m_dPercentFile;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bPreview;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4624)]
	public struct GetOPFSettingsResult_t
	{
		public const int k_iCallback = 4624;

		public EResult m_eResult;

		public AppId_t m_unVideoAppID;
	}
}
