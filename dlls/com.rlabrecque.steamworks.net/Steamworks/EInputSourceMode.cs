using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum EInputSourceMode
	{
		k_EInputSourceMode_None,
		k_EInputSourceMode_Dpad,
		k_EInputSourceMode_Buttons,
		k_EInputSourceMode_FourButtons,
		k_EInputSourceMode_AbsoluteMouse,
		k_EInputSourceMode_RelativeMouse,
		k_EInputSourceMode_JoystickMove,
		k_EInputSourceMode_JoystickMouse,
		k_EInputSourceMode_JoystickCamera,
		k_EInputSourceMode_ScrollWheel,
		k_EInputSourceMode_Trigger,
		k_EInputSourceMode_TouchMenu,
		k_EInputSourceMode_MouseJoystick,
		k_EInputSourceMode_MouseRegion,
		k_EInputSourceMode_RadialMenu,
		k_EInputSourceMode_SingleButton,
		k_EInputSourceMode_Switches
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(701)]
	public struct IPCountry_t
	{
		public const int k_iCallback = 701;
	}
}
