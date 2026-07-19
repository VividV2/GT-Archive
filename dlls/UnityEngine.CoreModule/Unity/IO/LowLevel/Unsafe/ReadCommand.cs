using System;
using System;

namespace Unity.IO.LowLevel.Unsafe
{
	public struct ReadCommand
	{
		public unsafe void* Buffer;

		public long Offset;

		public long Size;
	}
}
namespace UnityEngine
{
	[Flags]
	public enum RenderTextureCreationFlags
	{
		MipMap = 1,
		AutoGenerateMips = 2,
		SRGB = 4,
		EyeTexture = 8,
		EnableRandomWrite = 0x10,
		CreatedFromScript = 0x20,
		AllowVerticalFlip = 0x80,
		NoResolvedColorSurface = 0x100,
		DynamicallyScalable = 0x400,
		BindMS = 0x800,
		ShadingRate = 0x4000,
		DynamicallyScalableExplicit = 0x20000
	}
}
namespace JetBrains.Annotations
{
}
