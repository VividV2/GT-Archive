using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	internal static class ScrollWaitDefinitions
	{
		public const int firstWait = 250;

		public const int regularWait = 30;
	}
}
namespace Unity.Collections
{
	internal sealed class NativeSliceDebugView<T> where T : struct
	{
		private NativeSlice<T> m_Array;

		public T[] Items => m_Array.ToArray();

		public NativeSliceDebugView(NativeSlice<T> array)
		{
			m_Array = array;
		}
	}
}
namespace UnityEngine.Rendering
{
}
namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	public struct CullingSplit
	{
		public Vector3 sphereCenter;

		public float sphereRadius;

		public int cullingPlaneOffset;

		public int cullingPlaneCount;

		public float cascadeBlendCullingFactor;

		public float nearPlane;

		public Matrix4x4 cullingMatrix;
	}
}
