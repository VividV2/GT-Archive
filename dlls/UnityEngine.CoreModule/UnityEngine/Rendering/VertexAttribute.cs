using System;
using UnityEngine.Scripting.APIUpdating;
using System;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	[Flags]
	public enum MeshUpdateFlags
	{
		Default = 0,
		DontValidateIndices = 1,
		DontResetBoneBounds = 2,
		DontNotifyMeshUsers = 4,
		DontRecalculateBounds = 8,
		DontValidateLodRanges = 0x10
	}
}
namespace UnityEngine.Rendering
{
	[MovedFrom("UnityEngine.Experimental.Rendering")]
	public enum VertexAttribute
	{
		Position,
		Normal,
		Tangent,
		Color,
		TexCoord0,
		TexCoord1,
		TexCoord2,
		TexCoord3,
		TexCoord4,
		TexCoord5,
		TexCoord6,
		TexCoord7,
		BlendWeight,
		BlendIndices
	}
}
