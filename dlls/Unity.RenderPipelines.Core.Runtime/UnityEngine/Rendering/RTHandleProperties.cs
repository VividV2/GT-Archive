namespace UnityEngine.Rendering
{
	public enum DepthBits
	{
		None = 0,
		Depth8 = 8,
		Depth16 = 16,
		Depth24 = 24,
		Depth32 = 32
	}
}
namespace UnityEngine.Rendering
{
	public struct RTHandleProperties
	{
		public Vector2Int previousViewportSize;

		public Vector2Int previousRenderTargetSize;

		public Vector2Int currentViewportSize;

		public Vector2Int currentRenderTargetSize;

		public Vector4 rtHandleScale;
	}
}
