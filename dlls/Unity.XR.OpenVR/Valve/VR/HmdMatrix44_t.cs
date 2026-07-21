using System;
using System.Runtime.InteropServices;
using System;
using System;

namespace Valve.VR
{
	public enum EChaperoneConfigFile
	{
		Live = 1,
		Temp
	}
}
namespace Valve.VR
{
	public struct HmdMatrix44_t
	{
		public float m0;

		public float m1;

		public float m2;

		public float m3;

		public float m4;

		public float m5;

		public float m6;

		public float m7;

		public float m8;

		public float m9;

		public float m10;

		public float m11;

		public float m12;

		public float m13;

		public float m14;

		public float m15;
	}
}
namespace Valve.VR
{
	public struct IVRBlockQueue
	{
		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _Create(ref ulong pulQueueHandle, IntPtr pchPath, uint unBlockDataSize, uint unBlockHeaderSize, uint unBlockCount);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _Connect(ref ulong pulQueueHandle, IntPtr pchPath);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _Destroy(ulong ulQueueHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _AcquireWriteOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _ReleaseWriteOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _WaitAndAcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType, uint unTimeoutMs);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _AcquireReadOnlyBlock(ulong ulQueueHandle, ref ulong pulBlockHandle, ref IntPtr ppvBuffer, EBlockQueueReadType eReadType);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _ReleaseReadOnlyBlock(ulong ulQueueHandle, ulong ulBlockHandle);

		[UnmanagedFunctionPointer(CallingConvention.StdCall)]
		internal delegate EBlockQueueError _QueueHasReader(ulong ulQueueHandle, ref bool pbHasReaders);

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Create Create;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Connect Connect;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _Destroy Destroy;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AcquireWriteOnlyBlock AcquireWriteOnlyBlock;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseWriteOnlyBlock ReleaseWriteOnlyBlock;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _WaitAndAcquireReadOnlyBlock WaitAndAcquireReadOnlyBlock;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _AcquireReadOnlyBlock AcquireReadOnlyBlock;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _ReleaseReadOnlyBlock ReleaseReadOnlyBlock;

		[MarshalAs(UnmanagedType.FunctionPtr)]
		internal _QueueHasReader QueueHasReader;
	}
}
namespace Valve.VR
{
	public struct VRTextureWithPose_t
	{
		public IntPtr handle;

		public ETextureType eType;

		public EColorSpace eColorSpace;

		public HmdMatrix34_t mDeviceToAbsoluteTracking;
	}
}
namespace Valve.VR
{
	public enum ETrackingResult
	{
		Uninitialized = 1,
		Calibrating_InProgress = 100,
		Calibrating_OutOfRange = 101,
		Running_OK = 200,
		Running_OutOfRange = 201,
		Fallback_RotationOnly = 300
	}
}
