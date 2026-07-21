namespace Voxels;

public enum ChunkState
{
	UNINITIALIZED,
	Created,
	VoxelDataGenerated,
	MeshDataGenerated,
	MeshCreated,
	CollisionBaked,
	MeshAssigned
}
[Serializable]
public struct MatrixZonePair
{
	[]
	public Matrix4x4 matrix;

	[]
	public int zoneIndex;
}
