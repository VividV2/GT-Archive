using System;

namespace Unity.XR.OpenVR
{
}
namespace Valve.VR
{
	public struct VREvent_ShowDevTools_t
	{
		public int nBrowserIdentifier;
	}
}
namespace Valve.VR
{
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
