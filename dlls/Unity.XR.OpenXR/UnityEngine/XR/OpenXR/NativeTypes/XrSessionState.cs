using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;

namespace UnityEngine.XR.OpenXR
{
}
namespace UnityEngine.XR.OpenXR
{
}
namespace UnityEngine.XR.OpenXR
{
}
namespace UnityEngine.XR.OpenXR
{
}
namespace UnityEngine.XR.OpenXR
{
}
namespace UnityEngine.XR.OpenXR
{
}
namespace UnityEngine.XR.OpenXR.Input
{
}
namespace UnityEngine.XR.OpenXR.API
{
	public struct UnityXRTextureData
	{
		public IntPtr nativePtr;

		public uint referenceTextureId;
	}
}
namespace UnityEngine.XR.OpenXR.API
{
	public enum UnityXRDepthTextureFormat
	{
		kUnityXRDepthTextureFormat24bitOrGreater,
		kUnityXRDepthTextureFormat16bit,
		kUnityXRDepthTextureFormatReference,
		kUnityXRDepthTextureFormatNone
	}
}
namespace UnityEngine.XR.OpenXR.API
{
	public enum UnityXRRenderTextureFormat
	{
		kUnityXRRenderTextureFormatRGBA32 = 0,
		kUnityXRRenderTextureFormatBGRA32 = 1,
		kUnityXRRenderTextureFormatRGB565 = 2,
		kUnityXRRenderTextureFormatR16G16B16A16_SFloat = 3,
		kUnityXRRenderTextureFormatRGBA1010102 = 4,
		kUnityXRRenderTextureFormatBGRA1010102 = 5,
		kUnityXRRenderTextureFormatR11G11B10_UFloat = 6,
		kUnityXRRenderTextureFormatReference = 64,
		kUnityXRRenderTextureFormatSoftReferenceMSAA = 65,
		kUnityXRRenderTextureFormatNone = 66
	}
}
namespace UnityEngine.XR.OpenXR.API
{
	public static class UnityXRDisplay
	{
		public const uint kUnityXRRenderTextureIdDontCare = 0u;

		private const string k_UnityOpenXRLib = "UnityOpenXR";

		[DllImport("UnityOpenXR", EntryPoint = "Display_CreateTexture")]
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool CreateTexture(UnityXRRenderTextureDesc desc, out uint id);

		[DllImport("UnityOpenXR", EntryPoint = "Display_DestroyTexture")]
		[return: MarshalAs(UnmanagedType.U1)]
		public static extern bool DestroyTexture(uint textureId);
	}
}
namespace UnityEngine.XR.OpenXR.API
{
	public struct UnityXRRenderTextureDesc
	{
		public UnityXRRenderTextureFormat colorFormat;

		public UnityXRTextureData color;

		public UnityXRDepthTextureFormat depthFormat;

		public UnityXRTextureData depth;

		public UnityXRShadingRateFormat shadingRateFormat;

		public UnityXRTextureData shadingRate;

		public uint width;

		public uint height;

		public uint textureArrayLength;

		public uint flags;
	}
}
namespace UnityEngine.XR.OpenXR.Input
{
}
namespace UnityEngine.XR.OpenXR.API
{
	public enum UnityXRRenderTextureFlags
	{
		kUnityXRRenderTextureFlagsUVDirectionTopToBottom = 1,
		kUnityXRRenderTextureFlagsMultisampleAutoResolve = 2,
		kUnityXRRenderTextureFlagsLockedWidthHeight = 4,
		kUnityXRRenderTextureFlagsWriteOnly = 8,
		kUnityXRRenderTextureFlagsSRGB = 0x10,
		kUnityXRRenderTextureFlagsOptimizeBufferDiscards = 0x20,
		kUnityXRRenderTextureFlagsMotionVectorTexture = 0x40,
		kUnityXRRenderTextureFlagsFoveationOffset = 0x80,
		kUnityXRRenderTextureFlagsViewportAsRenderArea = 0x100,
		kUnityXRRenderTextureFlagsHDR = 0x200
	}
}
namespace UnityEngine.XR.OpenXR.Input
{
}
namespace UnityEngine.XR.OpenXR.Input
{
}
namespace UnityEngine.XR.OpenXR.Features
{
}
namespace UnityEngine.XR.OpenXR.NativeTypes
{
	public enum XrSessionState
	{
		Unknown,
		Idle,
		Ready,
		Synchronized,
		Visible,
		Focused,
		Stopping,
		LossPending,
		Exiting
	}
}
namespace UnityEngine.XR.OpenXR.NativeTypes
{
	public enum XrViewConfigurationType
	{
		PrimaryMono = 1,
		PrimaryStereo = 2,
		PrimaryQuadVarjo = 1000037000,
		SecondaryMonoFirstPersonObserver = 1000054000,
		SecondaryMonoThirdPersonObserver = 1000145000
	}
}
