using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using UnityEngine.Bindings;
using UnityEngine.Rendering;
using UnityEngine.Scripting.APIUpdating;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;
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
	[MovedFrom("UnityEngine.Experimental.U2D")]
	public struct SpriteShapeMetaData
	{
		public float height;

		public float bevelCutoff;

		public float bevelSize;

		public uint spriteIndex;

		public bool corner;
	}
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
	[MovedFrom("UnityEngine.Experimental.U2D")]
	[NativeType(Header = "Modules/SpriteShape/Public/SpriteShapeRenderer.h")]
	public class SpriteShapeRenderer : Renderer
	{
		public Color color
		{
			get
			{
				IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				get_color_Injected(intPtr, out var ret);
				return ret;
			}
			set
			{
				IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				set_color_Injected(intPtr, ref value);
			}
		}

		public SpriteMaskInteraction maskInteraction
		{
			get
			{
				IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				return get_maskInteraction_Injected(intPtr);
			}
			set
			{
				IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
				if (intPtr == (IntPtr)0)
				{
					ThrowHelper.ThrowNullReferenceException(this);
				}
				set_maskInteraction_Injected(intPtr, value);
			}
		}

		public void Prepare(JobHandle handle, SpriteShapeParameters shapeParams, Sprite[] sprites)
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			Prepare_Injected(intPtr, ref handle, ref shapeParams, sprites);
		}

		private unsafe NativeArray<T> GetNativeDataArray<T>(SpriteShapeDataType dataType) where T : struct
		{
			SpriteChannelInfo dataInfo = GetDataInfo(dataType);
			return NativeArrayUnsafeUtility.ConvertExistingDataToNativeArray<T>(dataInfo.buffer, dataInfo.count, Allocator.Invalid);
		}

		private unsafe NativeSlice<T> GetChannelDataArray<T>(SpriteShapeDataType dataType, VertexAttribute channel) where T : struct
		{
			SpriteChannelInfo channelInfo = GetChannelInfo(channel);
			byte* dataPointer = (byte*)channelInfo.buffer + channelInfo.offset;
			return NativeSliceUnsafeUtility.ConvertExistingDataToNativeSlice<T>(dataPointer, channelInfo.stride, channelInfo.count);
		}

		private void SetSegmentCount(int geomCount)
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			SetSegmentCount_Injected(intPtr, geomCount);
		}

		private void SetMeshDataCount(int vertexCount, int indexCount)
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			SetMeshDataCount_Injected(intPtr, vertexCount, indexCount);
		}

		private void SetMeshChannelInfo(int vertexCount, int indexCount, int hotChannelMask)
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			SetMeshChannelInfo_Injected(intPtr, vertexCount, indexCount, hotChannelMask);
		}

		private SpriteChannelInfo GetDataInfo(SpriteShapeDataType arrayType)
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			GetDataInfo_Injected(intPtr, arrayType, out var ret);
			return ret;
		}

		private SpriteChannelInfo GetChannelInfo(VertexAttribute channel)
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			GetChannelInfo_Injected(intPtr, channel, out var ret);
			return ret;
		}

		public void SetLocalAABB(Bounds bounds)
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			SetLocalAABB_Injected(intPtr, ref bounds);
		}

		public int GetSplineMeshCount()
		{
			IntPtr intPtr = MarshalledUnityObject.MarshalNotNull(this);
			if (intPtr == (IntPtr)0)
			{
				ThrowHelper.ThrowNullReferenceException(this);
			}
			return GetSplineMeshCount_Injected(intPtr);
		}

		public NativeArray<Bounds> GetBounds()
		{
			return GetNativeDataArray<Bounds>(SpriteShapeDataType.BoundingBox);
		}

		public NativeArray<SpriteShapeSegment> GetSegments(int dataSize)
		{
			SetSegmentCount(dataSize);
			return GetNativeDataArray<SpriteShapeSegment>(SpriteShapeDataType.Segment);
		}

		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords)
		{
			SetMeshDataCount(dataSize, dataSize);
			indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
		}

		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Color32> colors)
		{
			SetMeshChannelInfo(dataSize, dataSize, 8);
			indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			colors = GetChannelDataArray<Color32>(SpriteShapeDataType.ChannelColor, VertexAttribute.Color);
		}

		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Vector4> tangents)
		{
			SetMeshChannelInfo(dataSize, dataSize, 4);
			indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			tangents = GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
		}

		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Color32> colors, out NativeSlice<Vector4> tangents)
		{
			SetMeshChannelInfo(dataSize, dataSize, 12);
			indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			colors = GetChannelDataArray<Color32>(SpriteShapeDataType.ChannelColor, VertexAttribute.Color);
			tangents = GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
		}

		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Vector4> tangents, out NativeSlice<Vector3> normals)
		{
			SetMeshChannelInfo(dataSize, dataSize, 6);
			indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			tangents = GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
			normals = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelNormal, VertexAttribute.Normal);
		}

		public void GetChannels(int dataSize, out NativeArray<ushort> indices, out NativeSlice<Vector3> vertices, out NativeSlice<Vector2> texcoords, out NativeSlice<Color32> colors, out NativeSlice<Vector4> tangents, out NativeSlice<Vector3> normals)
		{
			SetMeshChannelInfo(dataSize, dataSize, 14);
			indices = GetNativeDataArray<ushort>(SpriteShapeDataType.Index);
			vertices = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelVertex, VertexAttribute.Position);
			texcoords = GetChannelDataArray<Vector2>(SpriteShapeDataType.ChannelTexCoord0, VertexAttribute.TexCoord0);
			colors = GetChannelDataArray<Color32>(SpriteShapeDataType.ChannelColor, VertexAttribute.Color);
			tangents = GetChannelDataArray<Vector4>(SpriteShapeDataType.ChannelTangent, VertexAttribute.Tangent);
			normals = GetChannelDataArray<Vector3>(SpriteShapeDataType.ChannelNormal, VertexAttribute.Normal);
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void get_color_Injected(IntPtr _unity_self, out Color ret);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_color_Injected(IntPtr _unity_self, [In] ref Color value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Prepare_Injected(IntPtr _unity_self, [In] ref JobHandle handle, [In] ref SpriteShapeParameters shapeParams, Sprite[] sprites);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetSegmentCount_Injected(IntPtr _unity_self, int geomCount);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetMeshDataCount_Injected(IntPtr _unity_self, int vertexCount, int indexCount);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetMeshChannelInfo_Injected(IntPtr _unity_self, int vertexCount, int indexCount, int hotChannelMask);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetDataInfo_Injected(IntPtr _unity_self, SpriteShapeDataType arrayType, out SpriteChannelInfo ret);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GetChannelInfo_Injected(IntPtr _unity_self, VertexAttribute channel, out SpriteChannelInfo ret);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void SetLocalAABB_Injected(IntPtr _unity_self, [In] ref Bounds bounds);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int GetSplineMeshCount_Injected(IntPtr _unity_self);
	}
}
namespace UnityEngine.U2D
{
	[MovedFrom("UnityEngine.Experimental.U2D")]
	[NativeHeader("Modules/SpriteShape/Public/SpriteShapeUtility.h")]
	public class SpriteShapeUtility
	{
		[FreeFunction("SpriteShapeUtility::Generate")]
		[NativeThrows]
		public unsafe static int[] Generate(Mesh mesh, SpriteShapeParameters shapeParams, ShapeControlPoint[] points, SpriteShapeMetaData[] metaData, AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners)
		{
			BlittableArrayWrapper ret = default(BlittableArrayWrapper);
			int[] result;
			BlittableArrayWrapper ret = default(BlittableArrayWrapper);
			int[] result;
			try
			{
				IntPtr mesh2 = Object.MarshalledUnityObject.Marshal(mesh);
				Span<ShapeControlPoint> span = new Span<ShapeControlPoint>(points);
				Span<ShapeControlPoint> span;
				fixed (ShapeControlPoint* begin = span)
				{
					ManagedSpanWrapper points2 = new ManagedSpanWrapper(begin, span.Length);
					Span<SpriteShapeMetaData> span2 = new Span<SpriteShapeMetaData>(metaData);
					Span<SpriteShapeMetaData> span2;
					fixed (SpriteShapeMetaData* begin2 = span2)
					{
						ManagedSpanWrapper metaData2 = new ManagedSpanWrapper(begin2, span2.Length);
						IntPtr mesh2;
						ManagedSpanWrapper points2;
						ManagedSpanWrapper metaData2;
						Generate_Injected(mesh2, ref shapeParams, ref points2, ref metaData2, angleRange, sprites, corners, out ret);
					}
				}
			}
			finally
			{
				int[] array = default(int[]);
				int[] array = default(int[]);
				ret.Unmarshal(ref array);
				result = array;
			}
			return result;
		}

		[FreeFunction("SpriteShapeUtility::GenerateSpriteShape")]
		[NativeThrows]
		public unsafe static void GenerateSpriteShape(SpriteShapeRenderer renderer, SpriteShapeParameters shapeParams, ShapeControlPoint[] points, SpriteShapeMetaData[] metaData, AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners)
		{
			IntPtr renderer2 = Object.MarshalledUnityObject.Marshal(renderer);
			Span<ShapeControlPoint> span = new Span<ShapeControlPoint>(points);
			Span<ShapeControlPoint> span;
			fixed (ShapeControlPoint* begin = span)
			{
				ManagedSpanWrapper points2 = new ManagedSpanWrapper(begin, span.Length);
				Span<SpriteShapeMetaData> span2 = new Span<SpriteShapeMetaData>(metaData);
				Span<SpriteShapeMetaData> span2;
				fixed (SpriteShapeMetaData* begin2 = span2)
				{
					ManagedSpanWrapper metaData2 = new ManagedSpanWrapper(begin2, span2.Length);
					IntPtr renderer2;
					ManagedSpanWrapper points2;
					ManagedSpanWrapper metaData2;
					GenerateSpriteShape_Injected(renderer2, ref shapeParams, ref points2, ref metaData2, angleRange, sprites, corners);
				}
			}
		}

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Generate_Injected(IntPtr mesh, [In] ref SpriteShapeParameters shapeParams, ref ManagedSpanWrapper points, ref ManagedSpanWrapper metaData, AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners, out BlittableArrayWrapper ret);

		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void GenerateSpriteShape_Injected(IntPtr renderer, [In] ref SpriteShapeParameters shapeParams, ref ManagedSpanWrapper points, ref ManagedSpanWrapper metaData, AngleRangeInfo[] angleRange, Sprite[] sprites, Sprite[] corners);
	}
}
