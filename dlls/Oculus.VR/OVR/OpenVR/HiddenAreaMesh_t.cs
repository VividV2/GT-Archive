using System;
using System;

namespace OVR.OpenVR
{
	public struct HiddenAreaMesh_t
	{
		public IntPtr pVertexData;

		public uint unTriangleCount;
	}
}
namespace OVR.OpenVR
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
