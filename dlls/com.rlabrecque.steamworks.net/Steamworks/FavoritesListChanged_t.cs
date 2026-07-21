using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(502)]
	public struct FavoritesListChanged_t
	{
		public const int k_iCallback = 502;

		public uint m_nIP;

		public uint m_nQueryPort;

		public uint m_nConnPort;

		public uint m_nAppID;

		public uint m_nFlags;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAdd;

		public AccountID_t m_unAccountId;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4508)]
	public struct HTML_ChangedTitle_t
	{
		public const int k_iCallback = 4508;

		public HHTMLBrowser unBrowserHandle;

		public string pchTitle;
	}
}
