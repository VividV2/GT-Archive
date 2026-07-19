namespace OVR.OpenVR
{
	public enum EVSync
	{
		None,
		WaitRender,
		NoWaitRender
	}
}
namespace OVR.OpenVR
{
	public enum EVRComponentProperty
	{
		IsStatic = 1,
		IsVisible = 2,
		IsTouched = 4,
		IsPressed = 8,
		IsScrolled = 0x10
	}
}
namespace OVR.OpenVR
{
	public enum EVRTrackedCameraFrameType
	{
		Distorted,
		Undistorted,
		MaximumUndistorted,
		MAX_CAMERA_FRAME_TYPES
	}
}
