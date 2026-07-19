namespace Valve.VR
{
	public struct RenderModel_ComponentState_t
	{
		public HmdMatrix34_t mTrackingToComponentRenderModel;

		public HmdMatrix34_t mTrackingToComponentLocal;

		public uint uProperties;
	}
}
namespace Valve.VR
{
	public struct VREvent_Scroll_t
	{
		public float xdelta;

		public float ydelta;

		public uint unused;

		public float viewportscale;
	}
}
