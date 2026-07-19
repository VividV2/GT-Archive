namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(2302)]
	public struct ScreenshotRequested_t
	{
		public const int k_iCallback = 2302;
	}
}
namespace Steamworks
{
	public enum EControllerHapticType
	{
		k_EControllerHapticType_Off,
		k_EControllerHapticType_Tick,
		k_EControllerHapticType_Click
	}
}
