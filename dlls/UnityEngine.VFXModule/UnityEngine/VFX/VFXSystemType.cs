using System;
using System;

namespace UnityEngine.VFX
{
	internal enum VFXSystemType
	{
		Spawner,
		Particle,
		Mesh,
		OutputEvent
	}
}
namespace UnityEngine.VFX
{
	[Flags]
	public enum VFXCameraBufferTypes
	{
		None = 0,
		Depth = 1,
		Color = 2,
		Normal = 4
	}
}
