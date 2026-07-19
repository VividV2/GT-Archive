namespace Valve.VR
{
	public enum EColorSpace
	{
		Auto,
		Gamma,
		Linear
	}
}
namespace Valve.VR
{
	public struct IVRNotifications
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _CreateNotification(ulong ulOverlayHandle, ulong ulUserValue, EVRNotificationType type, IntPtr pchText, EVRNotificationStyle style, ref NotificationBitmap_t pImage, ref uint pNotificationId);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EVRNotificationError _RemoveNotification(uint notificationId);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _CreateNotification CreateNotification;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _RemoveNotification RemoveNotification;
	}
}
namespace Valve.VR
{
}
