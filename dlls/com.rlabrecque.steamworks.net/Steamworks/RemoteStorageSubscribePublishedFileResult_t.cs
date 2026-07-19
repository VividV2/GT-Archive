using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4516)]
	public struct HTML_FileOpenDialog_t
	{
		public const int k_iCallback = 4516;

		public HHTMLBrowser unBrowserHandle;

		public string pchTitle;

		public string pchInitialFile;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1313)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		public const int k_iCallback = 1313;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
}
