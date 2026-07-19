namespace Valve.VR
{
	public struct PropertyRead_t
	{
		public ETrackedDeviceProperty prop;

		public IntPtr pvBuffer;

		public uint unBufferSize;

		public uint unTag;

		public uint unRequiredBufferSize;

		public ETrackedPropertyError eError;
	}
}
namespace Valve.VR
{
	public enum EVRNotificationError
	{
		OK = 0,
		InvalidNotificationId = 100,
		NotificationQueueFull = 101,
		InvalidOverlayHandle = 102,
		SystemWithUserValueAlreadyExists = 103
	}
}
