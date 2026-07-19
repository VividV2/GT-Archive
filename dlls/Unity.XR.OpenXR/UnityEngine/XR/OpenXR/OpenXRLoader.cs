using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.Scripting;
using System;
using System.Runtime.InteropServices;
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
	public class OpenXRLoader : OpenXRLoaderBase
	{
	}
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
	[Preserve]
	public class HapticControl : InputControl<Haptic>
	{
		public HapticControl()
		{
			m_StateBlock.sizeInBits = 1u;
			m_StateBlock.bitOffset = 0u;
			m_StateBlock.byteOffset = 0u;
		}

		public unsafe override Haptic ReadUnprocessedValueFromState(void* statePtr)
		{
			return default(Haptic);
		}
	}
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
	[Preserve]
	[UnityEngine.InputSystem.Layouts.InputControlLayout(displayName = "OpenXR Action Map")]
	public abstract class OpenXRDevice : UnityEngine.InputSystem.InputDevice
	{
		protected override void FinishSetup()
		{
			base.FinishSetup();
			XRDeviceDescriptor xRDeviceDescriptor = UnityEngine.InputSystem.XR.XRDeviceDescriptor.FromJson(base.description.capabilities);
			if (xRDeviceDescriptor != null)
			{
				if ((xRDeviceDescriptor.characteristics & InputDeviceCharacteristics.Left) != InputDeviceCharacteristics.None)
				{
					UnityEngine.InputSystem.InputSystem.SetDeviceUsage(this, UnityEngine.InputSystem.CommonUsages.LeftHand);
				}
				else if ((xRDeviceDescriptor.characteristics & InputDeviceCharacteristics.Right) != InputDeviceCharacteristics.None)
				{
					UnityEngine.InputSystem.InputSystem.SetDeviceUsage(this, UnityEngine.InputSystem.CommonUsages.RightHand);
				}
			}
		}
	}
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
namespace UnityEngine.XR.OpenXR.NativeTypes
{
	[Flags]
	public enum XrSwapchainUsageFlags : ulong
	{
		XR_SWAPCHAIN_USAGE_COLOR_ATTACHMENT_BIT = 1uL,
		XR_SWAPCHAIN_USAGE_DEPTH_STENCIL_ATTACHMENT_BIT = 2uL,
		XR_SWAPCHAIN_USAGE_UNORDERED_ACCESS_BIT = 4uL,
		XR_SWAPCHAIN_USAGE_TRANSFER_SRC_BIT = 8uL,
		XR_SWAPCHAIN_USAGE_TRANSFER_DST_BIT = 0x10uL,
		XR_SWAPCHAIN_USAGE_SAMPLED_BIT = 0x20uL,
		XR_SWAPCHAIN_USAGE_MUTABLE_FORMAT_BIT = 0x40uL,
		XR_SWAPCHAIN_USAGE_INPUT_ATTACHMENT_BIT_MND = 0x80uL,
		XR_SWAPCHAIN_USAGE_INPUT_ATTACHMENT_BIT_KHR = 0x80uL
	}
}
namespace UnityEngine.XR.OpenXR.NativeTypes
{
}
namespace UnityEngine.XR.OpenXR.NativeTypes
{
	[Flags]
	public enum XrViewStateFlags
	{
		None = 0,
		OrientationValid = 1,
		PositionValid = 2,
		OrientationTracked = 4,
		PositionTracked = 8
	}
}
