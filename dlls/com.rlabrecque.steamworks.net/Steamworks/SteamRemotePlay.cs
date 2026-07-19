using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks;

public enum EGamepadTextInputLineMode
{
	k_EGamepadTextInputLineModeSingleLine,
	k_EGamepadTextInputLineModeMultipleLines
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4514)]
	public struct HTML_JSAlert_t
	{
		public const int k_iCallback = 4514;

		public HHTMLBrowser unBrowserHandle;

		public string pchMessage;
	}
}
