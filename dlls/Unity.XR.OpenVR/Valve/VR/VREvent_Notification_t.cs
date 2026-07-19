namespace Valve.VR
{
	public struct VREvent_Notification_t
	{
		public ulong ulUserValue;

		public uint notificationId;
	}
}
namespace Valve.VR
{
	public struct RenderModel_t
	{
		public System.IntPtr rVertexData;

		public uint unVertexCount;

		public System.IntPtr rIndexData;

		public uint unTriangleCount;

		public int diffuseTextureId;
	}
}
