using System.Runtime.InteropServices;

namespace Valve.VR
{
	public enum EVRNotificationStyle
	{
		None = 0,
		Application = 100,
		Contact_Disabled = 200,
		Contact_Enabled = 201,
		Contact_Active = 202
	}
}
namespace Valve.VR
{
	public enum VRMessageOverlayResponse
	{
		ButtonPress_0,
		ButtonPress_1,
		ButtonPress_2,
		ButtonPress_3,
		CouldntFindSystemOverlay,
		CouldntFindOrCreateClientOverlay,
		ApplicationQuit
	}
}
namespace Valve.VR
{
	public struct IVRExtendedDisplay
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetWindowBounds(ref int pnX, ref int pnY, ref uint pnWidth, ref uint pnHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetEyeOutputViewport(EVREye eEye, ref uint pnX, ref uint pnY, ref uint pnWidth, ref uint pnHeight);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate void _GetDXGIOutputInfo(ref int pnAdapterIndex, ref int pnAdapterOutputIndex);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetWindowBounds GetWindowBounds;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetEyeOutputViewport GetEyeOutputViewport;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetDXGIOutputInfo GetDXGIOutputInfo;
	}
}
