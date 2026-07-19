using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System;

namespace DigitalOpus.MB.Core
{
	public enum MB_MeshPivotLocation
	{
		worldOrigin,
		boundsCenter,
		customLocation
	}
}
namespace DigitalOpus.MB.Core
{
	[Flags]
	public enum MB_MeshVertexChannelFlags
	{
		none = 0,
		vertex = 1,
		normal = 2,
		tangent = 4,
		colors = 8,
		uv0 = 0x10,
		nuvsSliceIdx = 0x20,
		uv2 = 0x40,
		uv3 = 0x80,
		uv4 = 0x100,
		uv5 = 0x200,
		uv6 = 0x400,
		uv7 = 0x800,
		uv8 = 0x1000,
		blendWeight = 0x2000,
		blendIndices = 0x4000
	}
}
namespace DigitalOpus.MB.Core
{
	public interface MBVersionInterface
	{
		string version();

		bool Is_2018_3_OrNewer();

		bool Is_2017_1_OrNewer();

		bool GetActive(UnityEngine.GameObject go);

		void SetActive(UnityEngine.GameObject go, bool isActive);

		void SetActiveRecursively(UnityEngine.GameObject go, bool isActive);

		UnityEngine.Object[] FindSceneObjectsOfType(Type t);

		bool IsRunningAndMeshNotReadWriteable(Mesh m);

		Vector2[] GetMeshUVChannel(int channel, Mesh m, MB2_LogLevel LOG_LEVEL);

		void MeshClear(Mesh m, bool t);

		void MeshAssignUVChannel(int channel, Mesh m, Vector2[] uvs);

		Vector4 GetLightmapTilingOffset(Renderer r);

		Transform[] GetBones(Renderer r, bool isSkinnedMeshWithBones);

		void OptimizeMesh(Mesh m);

		int GetBlendShapeFrameCount(Mesh m, int shapeIndex);

		float GetBlendShapeFrameWeight(Mesh m, int shapeIndex, int frameIndex);

		void GetBlendShapeFrameVertices(Mesh m, int shapeIndex, int frameIndex, Vector3[] vs, Vector3[] ns, Vector3[] ts);

		void ClearBlendShapes(Mesh m);

		void AddBlendShapeFrame(Mesh m, string nm, float wt, Vector3[] vs, Vector3[] ns, Vector3[] ts);

		int MaxMeshVertexCount();

		void SetMeshIndexFormatAndClearMesh(Mesh m, int numVerts, bool vertices, bool justClearTriangles);

		bool GraphicsUVStartsAtTop();

		bool IsTextureReadable(Texture2D tex);

		bool IsSwizzledNormalMapPlatform();

		bool IsMaterialKeywordValid(Material mat, string keyword);

		bool IsTexture_sRGBgammaCorrected(Texture2D tex, bool hint);

		bool CollectPropertyNames(List<ShaderTextureProperty> texPropertyNames, ShaderTextureProperty[] shaderTexPropertyNames, List<ShaderTextureProperty> _customShaderPropNames, Material resultMaterial, MB2_LogLevel LOG_LEVEL);

		void DoSpecialRenderPipeline_TexturePackerFastSetup(GameObject cameraGameObject);

		ColorSpace GetProjectColorSpace();

		MBVersion.PipelineType DetectPipeline();

		string UnescapeURL(string url);

		IEnumerator FindRuntimeMaterialsFromAddresses(MB2_TextureBakeResults textureBakeResult, MB2_TextureBakeResults.CoroutineResult isComplete);

		float GetScaleInLightmap(MeshRenderer r);

		bool IsAssetInProject(UnityEngine.Object target);
	}
}
