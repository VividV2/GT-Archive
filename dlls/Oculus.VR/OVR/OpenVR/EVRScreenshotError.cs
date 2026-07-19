namespace OVR.OpenVR;

public struct VREvent_Mouse_t
{
	public float x;

	public float y;

	public uint button;
}
namespace OVR.OpenVR
{
	public struct VREvent_MessageOverlay_t
	{
		public uint unVRMessageOverlayResponse;
	}
}
namespace OVR.OpenVR
{
	public enum EVRScreenshotError
	{
		None = 0,
		RequestFailed = 1,
		IncompatibleVersion = 100,
		NotFound = 101,
		BufferTooSmall = 102,
		ScreenshotAlreadyInProgress = 108
	}
}
