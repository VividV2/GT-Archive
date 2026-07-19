using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum EFloatingGamepadTextInputMode
	{
		k_EFloatingGamepadTextInputModeModeSingleLine,
		k_EFloatingGamepadTextInputModeModeMultipleLines,
		k_EFloatingGamepadTextInputModeModeEmail,
		k_EFloatingGamepadTextInputModeModeNumeric
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4515)]
	public struct HTML_JSConfirm_t
	{
		public const int k_iCallback = 4515;

		public HHTMLBrowser unBrowserHandle;

		public string pchMessage;
	}
}
