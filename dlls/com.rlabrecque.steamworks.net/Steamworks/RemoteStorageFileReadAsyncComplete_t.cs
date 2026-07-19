using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1332)]
	public struct RemoteStorageFileReadAsyncComplete_t
	{
		public const int k_iCallback = 1332;

		public SteamAPICall_t m_hFileReadAsync;

		public EResult m_eResult;

		public uint m_nOffset;

		public uint m_cubRead;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4503)]
	public struct HTML_StartRequest_t
	{
		public const int k_iCallback = 4503;

		public HHTMLBrowser unBrowserHandle;

		public string pchURL;

		public string pchTarget;

		public string pchPostData;

		[MarshalAs(UnmanagedType.I1)]
		public bool bIsRedirect;
	}
}
namespace Steamworks
{
}
namespace Steamworks
{
}
