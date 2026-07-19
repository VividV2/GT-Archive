using System;
using UnityEngine.Scripting;
using System;
using UnityEngine.Scripting;
using System;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[UsedByNativeCode]
	public struct ReflectionProbeBlendInfo
	{
		public ReflectionProbe probe;

		public float weight;
	}
}
namespace UnityEngine.Rendering
{
	public struct BatchDrawRange
	{
		public BatchDrawCommandType drawCommandsType;

		public uint drawCommandsBegin;

		public uint drawCommandsCount;

		public BatchFilterSettings filterSettings;
	}
}
namespace UnityEngine.Rendering
{
	[Flags]
	public enum ShaderPropertyFlags
	{
		None = 0,
		HideInInspector = 1,
		PerRendererData = 2,
		NoScaleOffset = 4,
		Normal = 8,
		HDR = 0x10,
		Gamma = 0x20,
		NonModifiableTextureData = 0x40,
		MainTexture = 0x80,
		MainColor = 0x100,
		Vector2 = 0x200,
		Vector3 = 0x400
	}
}
