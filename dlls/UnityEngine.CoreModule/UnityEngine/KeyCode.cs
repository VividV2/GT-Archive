using UnityEngine.SceneManagement;
using UnityEngine.SceneManagement;

namespace UnityEngine
{
	public struct InstantiateParameters
	{
		public Transform parent;

		public Scene scene;

		public bool worldSpace;

		public bool originalImmutable;
	}
}
namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	[NativeHeader("Runtime/Camera/BatchRendererGroup.h")]
	internal struct BatchRendererCullingOutput
	{
		public JobHandle cullingJobsFence;

		public Matrix4x4 localToWorldMatrix;

		public Plane* cullingPlanes;

		public int cullingPlaneCount;

		public int receiverPlaneOffset;

		public int receiverPlaneCount;

		public CullingSplit* cullingSplits;

		public int cullingSplitCount;

		public BatchCullingViewType viewType;

		public BatchCullingProjectionType projectionType;

		public BatchCullingFlags cullingFlags;

		public ulong viewID;

		public uint cullingLayerMask;

		public byte splitExclusionMask;

		public ulong sceneCullingMask;

		public BatchCullingOutputDrawCommands* drawCommands;

		public uint brgId;

		public IntPtr occlusionBuffer;

		public IntPtr customCullingResult;
	}
}
namespace UnityEngine
{
}
namespace UnityEngine.Windows.Speech
{
}
