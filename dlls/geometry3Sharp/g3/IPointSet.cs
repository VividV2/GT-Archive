using System;
using System.Collections.Generic;
using System;

namespace g3
{
	[Flags]
	public enum MeshHints
	{
		None = 0,
		IsCompact = 1
	}
}
namespace g3
{
	public interface IPointSet
	{
		int VertexCount { get; }

		int MaxVertexID { get; }

		bool HasVertexNormals { get; }

		bool HasVertexColors { get; }

		int Timestamp { get; }

		Vector3d GetVertex(int i);

		Vector3f GetVertexNormal(int i);

		Vector3f GetVertexColor(int i);

		bool IsVertex(int vID);

		IEnumerable<int> VertexIndices();
	}
}
