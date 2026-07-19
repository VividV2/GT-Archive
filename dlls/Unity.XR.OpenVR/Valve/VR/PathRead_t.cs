using System;

namespace Valve.VR;

public struct VREvent_Chaperone_t
{
	public ulong m_nPreviousUniverse;

	public ulong m_nCurrentUniverse;
}
namespace Valve.VR
{
	public struct PathRead_t
	{
		public ulong ulPath;

		public IntPtr pvBuffer;

		public uint unBufferSize;

		public uint unTag;

		public uint unRequiredBufferSize;

		public ETrackedPropertyError eError;

		public IntPtr pszPath;
	}
}
