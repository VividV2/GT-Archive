using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.U2D
{
	internal enum SpriteShapeDataType
	{
		Index,
		Segment,
		BoundingBox,
		ChannelVertex,
		ChannelTexCoord0,
		ChannelNormal,
		ChannelTangent,
		ChannelColor,
		DataCount
	}
}
namespace UnityEngine.U2D
{
}
namespace UnityEngine.U2D
{
	[MovedFrom("UnityEngine.Experimental.U2D")]
	public struct ShapeControlPoint
	{
		public Vector3 position;

		public Vector3 leftTangent;

		public Vector3 rightTangent;

		public int mode;
	}
}
namespace UnityEngine.U2D
{
	[MovedFrom("UnityEngine.Experimental.U2D")]
	public struct SpriteShapeParameters
	{
		public Matrix4x4 transform;

		public Texture2D fillTexture;

		public uint fillScale;

		public uint splineDetail;

		public float angleThreshold;

		public float borderPivot;

		public float bevelCutoff;

		public float bevelSize;

		public bool carpet;

		public bool smartSprite;

		public bool adaptiveUV;

		public bool spriteBorders;

		public bool stretchUV;
	}
}
namespace UnityEngine.U2D
{
	[MovedFrom("UnityEngine.Experimental.U2D")]
	public struct AngleRangeInfo
	{
		public float start;

		public float end;

		public uint order;

		public int[] sprites;
	}
}
namespace UnityEngine.U2D
{
}
namespace UnityEngine.U2D
{
}
