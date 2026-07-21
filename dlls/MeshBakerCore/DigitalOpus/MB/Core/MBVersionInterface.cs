using System;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

namespace DigitalOpus.MB.Core
{
	public interface MB_IMeshCombinerSingle_BoneProcessor : IDisposable
	{
		bool GetCachedSMRMeshData(MB_DynamicGameObject dgo);

		void AddBonesToNewBonesArrayAndAdjustBWIndexes1(MB_DynamicGameObject dgo, int vertsIdx);

		void AllocateAndSetupSMRDataStructures(List<MB_DynamicGameObject> toAddDGOs, List<MB_DynamicGameObject> mbDynamicObjectsInCombinedMesh, int newVertSize, IVertexAndTriangleProcessor vertexAndTriangleProcessor);

		void BuildBoneIdx2DGOMapIfNecessary(int[] _goToDelete);

		void CopyBonesWeAreKeepingToNewBonesArrayAndAdjustBWIndexes(int totalDeleteVerts);

		void InsertNewBonesIntoBonesArray();

		int GetNewBonesSize();

		void RemoveBonesForDgosWeAreDeleting(MB_DynamicGameObject dgo);

		void CopyBoneWeightsFromMeshForDGOsInCombined(MB_DynamicGameObject dgo, int targVidx);

		void CopyVertsNormsTansToBuffers(MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, Vector3[] nnorms, Vector4[] ntangs, Vector3[] nverts, Vector3[] normals, Vector4[] tangents, Vector3[] verts);

		void CopyVertsNormsTansToBuffers(MB_DynamicGameObject dgo, MB_IMeshBakerSettings settings, int vertsIdx, NativeSlice<Vector3> nnorms, NativeSlice<Vector4> ntangs, NativeSlice<Vector3> nverts, NativeSlice<Vector3> normals, NativeSlice<Vector4> tangents, NativeSlice<Vector3> verts);

		void DisposeOfTemporarySMRData();

		void ApplySMRdataToMeshToBuffer();

		void ApplySMRdataToMesh(MB3_MeshCombinerSingle combiner, Mesh mesh);

		void UpdateGameObjects_ReadBoneWeightInfoFromCombinedMesh();

		void UpdateGameObjects_UpdateBWIndexes(MB_DynamicGameObject dgo);

		bool DB_CheckIntegrity();
	}
}
