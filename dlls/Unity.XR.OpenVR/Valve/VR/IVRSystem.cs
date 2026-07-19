namespace Valve.VR
{
	public enum EVRControllerAxisType
	{
		k_eControllerAxis_None,
		k_eControllerAxis_TrackPad,
		k_eControllerAxis_Joystick,
		k_eControllerAxis_Trigger
	}
}
namespace Valve.VR
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct RenderModel_t_Packed
	{
		public IntPtr rVertexData;

		public uint unVertexCount;

		public IntPtr rIndexData;

		public uint unTriangleCount;

		public int diffuseTextureId;

		public RenderModel_t_Packed(RenderModel_t unpacked)
		{
			rVertexData = unpacked.rVertexData;
			unVertexCount = unpacked.unVertexCount;
			rIndexData = unpacked.rIndexData;
			unTriangleCount = unpacked.unTriangleCount;
			diffuseTextureId = unpacked.diffuseTextureId;
		}

		public void Unpack(ref RenderModel_t unpacked)
		{
			unpacked.rVertexData = rVertexData;
			unpacked.unVertexCount = unVertexCount;
			unpacked.rIndexData = rIndexData;
			unpacked.unTriangleCount = unTriangleCount;
			unpacked.diffuseTextureId = diffuseTextureId;
		}
	}
}
namespace Valve.VR
{
	public enum ETrackedPropertyError
	{
		TrackedProp_Success,
		TrackedProp_WrongDataType,
		TrackedProp_WrongDeviceClass,
		TrackedProp_BufferTooSmall,
		TrackedProp_UnknownProperty,
		TrackedProp_InvalidDevice,
		TrackedProp_CouldNotContactServer,
		TrackedProp_ValueNotProvidedByDevice,
		TrackedProp_StringExceedsMaximumLength,
		TrackedProp_NotYetAvailable,
		TrackedProp_PermissionDenied,
		TrackedProp_InvalidOperation,
		TrackedProp_CannotWriteToWildcards,
		TrackedProp_IPCReadFailure,
		TrackedProp_OutOfMemory,
		TrackedProp_InvalidContainer
	}
}
namespace Valve.VR
{
}
