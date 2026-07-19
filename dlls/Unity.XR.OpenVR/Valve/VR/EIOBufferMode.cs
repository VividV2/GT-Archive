namespace Valve.VR
{
	public enum EIOBufferMode
	{
		Read = 1,
		Write = 2,
		Create = 0x200
	}
}
namespace Valve.VR
{
	public enum ETrackedDeviceClass
	{
		Invalid,
		HMD,
		Controller,
		GenericTracker,
		TrackingReference,
		DisplayRedirect,
		Max
	}
}
