namespace OVR.OpenVR
{
	public enum EIOBufferError
	{
		IOBuffer_Success = 0,
		IOBuffer_OperationFailed = 100,
		IOBuffer_InvalidHandle = 101,
		IOBuffer_InvalidArgument = 102,
		IOBuffer_PathExists = 103,
		IOBuffer_PathDoesNotExist = 104,
		IOBuffer_Permission = 105
	}
}
namespace OVR.OpenVR
{
	public enum EVRScreenshotType
	{
		None,
		Mono,
		Stereo,
		Cubemap,
		MonoPanorama,
		StereoPanorama
	}
}
