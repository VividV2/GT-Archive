using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
using System;
using System.Runtime.InteropServices;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using UnityEngine.Scripting;
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
	public static class OpenXRUtility
	{
		private const string LibraryName = "UnityOpenXR";

		public static bool IsSessionFocused => Internal_IsSessionFocused();

		public static bool IsUserPresent => Internal_GetUserPresence();

		private static Pose Inverse(Pose p)
		{
			Pose result = default(Pose);
			Pose result = default(Pose);
			Pose result = default(Pose);
			result.rotation = Quaternion.Inverse(p.rotation);
			result.position = result.rotation * -p.position;
			return result;
		}

		public static Pose ComputePoseToWorldSpace(Transform t, Camera camera)
		{
			if (camera == null)
			{
				return default(Pose);
			}
			Transform transform = camera.transform;
			Transform transform;
			Transform transform;
			Pose lhs = new Pose(transform.localPosition, transform.localRotation);
			Pose p = new Pose(transform.position, transform.rotation);
			Pose p;
			Pose lhs;
			Pose p;
			Pose lhs;
			return new Pose(t.position, t.rotation).GetTransformedBy(Inverse(p)).GetTransformedBy(lhs);
		}

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_IsSessionFocused")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_IsSessionFocused();

		[DllImport("UnityOpenXR", EntryPoint = "NativeConfig_GetUserPresence")]
		[return: MarshalAs(UnmanagedType.U1)]
		private static extern bool Internal_GetUserPresence();
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
			XRDeviceDescriptor xRDeviceDescriptor;
			XRDeviceDescriptor xRDeviceDescriptor;
			XRDeviceDescriptor xRDeviceDescriptor;
			XRDeviceDescriptor xRDeviceDescriptor;
			XRDeviceDescriptor xRDeviceDescriptor;
			XRDeviceDescriptor xRDeviceDescriptor;
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
	public static class XrResultExtensions
	{
		public static bool IsSuccess(this XrResult xrResult)
		{
			return xrResult >= XrResult.Success;
		}

		public static bool IsUnqualifiedSuccess(this XrResult xrResult)
		{
			return xrResult == XrResult.Success;
		}

		public static bool IsError(this XrResult xrResult)
		{
			return xrResult < XrResult.Success;
		}
	}
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
namespace UnityEngine.XR.OpenXR.NativeTypes
{
	[Flags]
	public enum XrReferenceSpaceType
	{
		View = 1,
		Local = 2,
		Stage = 3,
		UnboundedMsft = 0x3B9B5E70,
		CombinedEyeVarjo = 0x3B9CA2A8
	}
}
namespace UnityEngine.XR.OpenXR.NativeTypes
{
	internal struct XrBaseInStructure
	{
		public uint Type;

		public unsafe void* Next;
	}
}
namespace UnityEngine.XR.OpenXR.NativeTypes
{
	public struct XrPosef(Vector3 vec3, Quaternion quaternion)
	{
		public XrQuaternionf Orientation = new XrQuaternionf(quaternion);

		public XrVector3f Position = new XrVector3f(vec3);
	}
}
namespace UnityEngine.XR.OpenXR.Features
{
}
namespace UnityEngine.XR.OpenXR.NativeTypes
{
	public enum XrResult
	{
		Success = 0,
		[Obsolete("This value is misspelled and therefore deprecated in OpenXR Plug-in version 1.14.0. Use TimeoutExpired instead.", false)]
		TimeoutExpored = 1,
		TimeoutExpired = 1,
		LossPending = 3,
		EventUnavailable = 4,
		SpaceBoundsUnavailable = 7,
		SessionNotFocused = 8,
		FrameDiscarded = 9,
		ValidationFailure = -1,
		RuntimeFailure = -2,
		OutOfMemory = -3,
		ApiVersionUnsupported = -4,
		InitializationFailed = -6,
		FunctionUnsupported = -7,
		FeatureUnsupported = -8,
		ExtensionNotPresent = -9,
		LimitReached = -10,
		SizeInsufficient = -11,
		HandleInvalid = -12,
		InstanceLost = -13,
		SessionRunning = -14,
		SessionNotRunning = -16,
		SessionLost = -17,
		SystemInvalid = -18,
		PathInvalid = -19,
		PathCountExceeded = -20,
		PathFormatInvalid = -21,
		PathUnsupported = -22,
		LayerInvalid = -23,
		LayerLimitExceeded = -24,
		SwapchainRectInvalid = -25,
		SwapchainFormatUnsupported = -26,
		ActionTypeMismatch = -27,
		SessionNotReady = -28,
		SessionNotStopping = -29,
		TimeInvalid = -30,
		ReferenceSpaceUnsupported = -31,
		FileAccessError = -32,
		FileContentsInvalid = -33,
		FormFactorUnsupported = -34,
		FormFactorUnavailable = -35,
		ApiLayerNotPresent = -36,
		CallOrderInvalid = -37,
		GraphicsDeviceInvalid = -38,
		PoseInvalid = -39,
		IndexOutOfRange = -40,
		ViewConfigurationTypeUnsupported = -41,
		EnvironmentBlendModeUnsupported = -42,
		NameDuplicated = -44,
		NameInvalid = -45,
		ActionsetNotAttached = -46,
		ActionsetsAlreadyAttached = -47,
		LocalizedNameDuplicated = -48,
		LocalizedNameInvalid = -49,
		GraphicsRequirementsCallMissing = -50,
		RuntimeUnavailable = -51,
		ExtensionDependencyNotEnabled = -1000710001,
		PermissionInsufficient = -1000710000,
		AndroidThreadSettingsIdInvalidKHR = -1000003000,
		[Obsolete("This enum value is misspelled and therefore deprecated in OpenXR Plug-in version 1.14.0. Use AndroidThreadSettingsFailureKHR instead.", false)]
		AndroidThreadSettingsdFailureKHR = -1000003001,
		AndroidThreadSettingsFailureKHR = -1000003001,
		CreateSpatialAnchorFailedMSFT = -1000039001,
		SecondaryViewConfigurationTypeNotEnabledMSFT = -1000053000,
		ControllerModelKeyInvalidMSFT = -1000055000,
		ReprojectionModeUnsupportedMSFT = -1000066000,
		ComputeNewSceneNotCompletedMSFT = -1000097000,
		SceneComponentIdInvalidMSFT = -1000097001,
		SceneComponentTypeMismatchMSFT = -1000097002,
		SceneMeshBufferIdInvalidMSFT = -1000097003,
		SceneComputeFeatureIncompatibleMSFT = -1000097004,
		SceneComputeConsistencyMismatchMSFT = -1000097005,
		DisplayRefreshRateUnsupportedFB = -1000101000,
		ColorSpaceUnsupportedFB = -1000108000,
		SpaceComponentNotSupportedFB = -1000113000,
		SpaceComponentNotEnabledFB = -1000113001,
		SpaceComponentStatusPendingFB = -1000113002,
		SpaceComponentStatusAlreadySetFB = -1000113003,
		UnexpectedStatePassthroughFB = -1000118000,
		FeatureAlreadyCreatedPassthroughFB = -1000118001,
		FeatureRequiredPassthroughFB = -1000118002,
		NotPermittedPassthroughFB = -1000118003,
		InsufficientResourcesPassthroughFB = -1000118004,
		UnknownPassthroughFB = -1000118050,
		RenderModelKeyInvalidFB = -1000119000,
		RenderModelUnavailableFB = 1000119020,
		MarkerNotTrackedVARJO = -1000124000,
		MarkerIdInvalidVARJO = -1000124001,
		MarkerDetectorPermissionDeniedML = -1000138000,
		MarkerDetectorLocateFailedML = -1000138001,
		MarkerDetectorInvalidDataQueryML = -1000138002,
		MarkerDetectorInvalidCreateInfoML = -1000138003,
		MarkerInvalidML = -1000138004,
		LocalizationMapIncompatibleML = -1000139000,
		LocalizationMapUnavailableML = -1000139001,
		LocalizationMapFailML = -1000139002,
		LocalizationMapImportExportPermissionDeniedML = -1000139003,
		LocalizationMapPermissionDeniedML = -1000139004,
		LocalizationMapAlreadyExistsML = -1000139005,
		LocalizationMapCannotExportCloudMapML = -1000139006,
		SpatialAnchorsPermissionDeniedML = -1000140000,
		SpatialAnchorsNotLocalizedML = -1000140001,
		SpatialAnchorsOutOfMapBoundsML = -1000140002,
		SpatialAnchorsSpaceNotLocatableML = -1000140003,
		SpatialAnchorsAnchorNotFoundML = -1000141000,
		SpatialAnchorNameNotFoundMSFT = -1000142001,
		SpatialAnchorNameInvalidMSFT = -1000142002,
		SceneMarkerDataNotStringMSFT = 1000147000,
		SpaceMappingInsufficientFB = -1000169000,
		SpaceLocalizationFailedFB = -1000169001,
		SpaceNetworkTimeoutFB = -1000169002,
		SpaceNetworkRequestFailedFB = -1000169003,
		SpaceCloudStorageDisabledFB = -1000169004,
		PassthroughColorLutBufferSizeMismatchMETA = -1000266000,
		EnvironmentDepthNotAvailableMETA = 1000291000,
		HintAlreadySetQCOM = -1000306000,
		NotAnAnchorHTC = -1000319000,
		SpaceNotLocatableEXT = -1000429000,
		PlaneDetectionPermissionDeniedEXT = -1000429001,
		FuturePendingEXT = -1000469001,
		FutureInvalidEXT = -1000469002,
		SystemNotificationPermissionDeniedML = -1000473000,
		SystemNotificationIncompatibleSkuML = -1000473001,
		WorldMeshDetectorPermissionDeniedML = -1000474000,
		WorldMeshDetectorSpaceNotLocatableML = -1000474001,
		FacialExpressionPermissionDeniedML = 1000482000,
		ColocationDiscoveryNetworkFailedMETA = -1000571001,
		ColocationDiscoveryNoDiscoveryMethodMETA = -1000571002,
		ColocationDiscoveryAlreadyAdvertisingMETA = 1000571003,
		ColocationDiscoveryAlreadyDiscoveringMETA = 1000571004,
		SpaceGroupNotFoundMETA = -1000572002,
		ExtensionDependencyNotEnabledKHR = -1000710001,
		PermissionInsufficientKHR = -1000710000,
		MaxResult = int.MaxValue
	}
}
namespace UnityEngine.XR.OpenXR.NativeTypes
{
	public struct XrQuaternionf
	{
		public float X;

		public float Y;

		public float Z;

		public float W;

		public XrQuaternionf(float x, float y, float z, float w)
		{
			X = 0f - x;
			Y = 0f - y;
			Z = z;
			W = w;
		}

		public XrQuaternionf(Quaternion quaternion)
		{
			X = 0f - quaternion.x;
			Y = 0f - quaternion.y;
			Z = quaternion.z;
			W = quaternion.w;
		}
	}
}
namespace UnityEngine.XR.OpenXR.Features.Interactions
{
	public static class EyeTrackingUsages
	{
		public static InputFeatureUsage<Vector3> gazePosition = new InputFeatureUsage<Vector3>("gazePosition");

		public static InputFeatureUsage<Quaternion> gazeRotation = new InputFeatureUsage<Quaternion>("gazeRotation");
	}
}
namespace UnityEngine.XR.OpenXR.Features.Extensions.PerformanceSettings
{
	public enum PerformanceNotificationLevel
	{
		Normal = 0,
		Warning = 25,
		Impaired = 75
	}
}
namespace UnityEngine.XR.OpenXR.Features.Extensions.PerformanceSettings
{
	public enum PerformanceLevelHint
	{
		PowerSavings = 0,
		SustainedLow = 25,
		SustainedHigh = 50,
		Boost = 75
	}
}
namespace UnityEngine.XR.OpenXR.Features.Interactions
{
}
namespace UnityEngine.XR.OpenXR.Features.Extensions.PerformanceSettings
{
}
namespace UnityEngine.XR.OpenXR.Features.Interactions
{
}
namespace UnityEngine.XR.OpenXR.Features.Interactions
{
}
namespace UnityEngine.XR.OpenXR.Features.Interactions
{
}
namespace UnityEngine.XR.OpenXR.Features.Interactions
{
}
namespace UnityEngine.XR.OpenXR.Features.Interactions
{
}
