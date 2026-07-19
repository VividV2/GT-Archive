using System;

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
}
namespace Valve.VR
{
	public enum EVRRenderModelError
	{
		None = 0,
		Loading = 100,
		NotSupported = 200,
		InvalidArg = 300,
		InvalidModel = 301,
		NoShapes = 302,
		MultipleShapes = 303,
		TooManyVertices = 304,
		MultipleTextures = 305,
		BufferTooSmall = 306,
		NotEnoughNormals = 307,
		NotEnoughTexCoords = 308,
		InvalidTexture = 400
	}
}
