using Unity.Mathematics;
using UnityEngine;
using Unity.Mathematics;
using UnityEngine;

public struct GTVertexDataStream1
{
	public float3 normal;

	public Color32 tangent;
}
public interface IGameEntityComponent
{
	void OnEntityInit();

	void OnEntityDestroy();

	void OnEntityStateChange(long prevState, long newState);
}
