using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using System;

namespace Valve.VR
{
	public struct IVRProperties
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedPropertyError _ReadPropertyBatch(ulong ulContainerHandle, ref PropertyRead_t pBatch, uint unBatchEntryCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ETrackedPropertyError _WritePropertyBatch(ulong ulContainerHandle, ref PropertyWrite_t pBatch, uint unBatchEntryCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate IntPtr _GetPropErrorNameFromEnum(ETrackedPropertyError error);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate ulong _TrackedDeviceToPropertyContainer(uint nDevice);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReadPropertyBatch ReadPropertyBatch;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _WritePropertyBatch WritePropertyBatch;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _GetPropErrorNameFromEnum GetPropErrorNameFromEnum;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _TrackedDeviceToPropertyContainer TrackedDeviceToPropertyContainer;
	}
}
namespace Valve.VR
{
	public enum EVRSceneApplicationState
	{
		None,
		Starting,
		Quitting,
		Running,
		Waiting
	}
}
namespace Valve.VR
{
	public struct PathWrite_t
	{
		public ulong ulPath;

		public EPropertyWriteType writeType;

		public ETrackedPropertyError eSetError;

		public IntPtr pvBuffer;

		public uint unBufferSize;

		public uint unTag;

		public ETrackedPropertyError eError;

		public IntPtr pszPath;
	}
}
namespace Valve.VR
{
	public struct VREvent_Notification_t
	{
		public ulong ulUserValue;

		public uint notificationId;
	}
}
namespace Valve.VR
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
