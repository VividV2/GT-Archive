using System.Runtime.InteropServices;

namespace Valve.VR
{
	public enum EVRApplicationError
	{
		None = 0,
		AppKeyAlreadyExists = 100,
		NoManifest = 101,
		NoApplication = 102,
		InvalidIndex = 103,
		UnknownApplication = 104,
		IPCFailed = 105,
		ApplicationAlreadyRunning = 106,
		InvalidManifest = 107,
		InvalidApplication = 108,
		LaunchFailed = 109,
		ApplicationAlreadyStarting = 110,
		LaunchInProgress = 111,
		OldApplicationQuitting = 112,
		TransitionAborted = 113,
		IsTemplate = 114,
		SteamVRIsExiting = 115,
		BufferTooSmall = 200,
		PropertyNotSet = 201,
		UnknownProperty = 202,
		InvalidParameter = 203
	}
}
namespace Valve.VR
{
	public struct IVRHeadsetView
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetHeadsetViewSize(uint nWidth, uint nHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetHeadsetViewSize(ref uint pnWidth, ref uint pnHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetHeadsetViewMode(uint eHeadsetViewMode);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate uint _GetHeadsetViewMode();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetHeadsetViewCropped(bool bCropped);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate bool _GetHeadsetViewCropped();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate float _GetHeadsetViewAspectRatio();

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _SetHeadsetViewBlendRange(float flStartPct, float flEndPct);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetHeadsetViewBlendRange(ref float pStartPct, ref float pEndPct);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetHeadsetViewSize SetHeadsetViewSize;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewSize GetHeadsetViewSize;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetHeadsetViewMode SetHeadsetViewMode;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewMode GetHeadsetViewMode;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetHeadsetViewCropped SetHeadsetViewCropped;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewCropped GetHeadsetViewCropped;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewAspectRatio GetHeadsetViewAspectRatio;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _SetHeadsetViewBlendRange SetHeadsetViewBlendRange;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetHeadsetViewBlendRange GetHeadsetViewBlendRange;
	}
}
namespace Valve.VR
{
	public enum ETextureType
	{
		Invalid = -1,
		DirectX,
		OpenGL,
		Vulkan,
		IOSurface,
		DirectX12,
		DXGISharedHandle,
		Metal
	}
}
