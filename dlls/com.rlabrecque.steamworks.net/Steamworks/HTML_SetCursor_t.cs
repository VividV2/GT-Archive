using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(5211)]
	public struct RequestPlayersForGameProgressCallback_t
	{
		public const int k_iCallback = 5211;

		public EResult m_eResult;

		public ulong m_ullSearchID;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4522)]
	public struct HTML_SetCursor_t
	{
		public const int k_iCallback = 4522;

		public HHTMLBrowser unBrowserHandle;

		public uint eMouseCursor;
	}
}
