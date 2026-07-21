namespace Valve.VR
{
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
