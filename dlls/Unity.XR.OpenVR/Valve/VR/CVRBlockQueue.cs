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
