using System;
using System;

namespace UnityEngine.Rendering.RadeonRays
{
	[Flags]
	internal enum BuildFlags
	{
		None = 0,
		PreferFastBuild = 1
	}
}
namespace UnityEngine.Rendering.RadeonRays
{
}
namespace UnityEngine.Rendering.RadeonRays
{
	internal struct InstanceInfo
	{
		public int blasOffset;

		public int instanceMask;

		public int vertexOffset;

		public int indexOffset;

		public int triangleCullingEnabled;

		public int invertTriangleCulling;

		public uint userInstanceID;

		public int padding2;

		public Transform worldToLocalTransform;

		public Transform localToWorldTransform;
	}
}
