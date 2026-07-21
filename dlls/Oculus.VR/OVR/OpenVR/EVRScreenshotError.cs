namespace OVR.OpenVR
{
	public enum VROverlayTransformType
	{
		VROverlayTransform_Absolute,
		VROverlayTransform_TrackedDeviceRelative,
		VROverlayTransform_SystemOverlay,
		VROverlayTransform_TrackedComponent
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
