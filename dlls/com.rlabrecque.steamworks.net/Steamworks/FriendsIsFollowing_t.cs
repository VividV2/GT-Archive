using System.Runtime.InteropServices;

namespace Steamworks;

[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(4510)]
public struct HTML_CanGoBackAndForward_t
{
	public const int k_iCallback = 4510;

	public HHTMLBrowser unBrowserHandle;

	[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
	public bool bCanGoBack;

	[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
	public bool bCanGoForward;
}
