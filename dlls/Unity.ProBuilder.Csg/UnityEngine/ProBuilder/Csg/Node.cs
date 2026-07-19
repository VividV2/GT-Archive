using System.Collections.Generic;
using System.Collections.Generic;

namespace UnityEngine.ProBuilder.Csg;

internal sealed class Polygon(List<Vertex> list, Material mat)
{
	public List<Vertex> vertices = list;

	public Plane plane = new Plane(list[0].position, list[1].position, list[2].position);

	public Material material = mat;

	public void Flip()
	{
		vertices.Reverse();
		int i;
		for (int i = 0; i < vertices.Count; i++)
		{
			vertices[i].Flip();
		}
		plane.Flip();
	}

	public override string ToString()
	{
		return $"[{vertices.Count}] {plane.normal}";
	}
}
