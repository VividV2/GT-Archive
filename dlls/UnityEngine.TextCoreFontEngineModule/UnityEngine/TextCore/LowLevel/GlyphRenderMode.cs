using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using System;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.TextCore.LowLevel
{
	[UsedByNativeCode]
	public enum GlyphRenderMode
	{
		DEFAULT = 0,
		SMOOTH_HINTED = 4121,
		SMOOTH = 4117,
		COLOR_HINTED = 69656,
		COLOR = 69652,
		RASTER_HINTED = 4122,
		RASTER = 4118,
		SDF = 4134,
		SDF8 = 8230,
		SDF16 = 16422,
		SDF32 = 32806,
		SDFAA_HINTED = 4169,
		SDFAA = 4165
	}
}
namespace UnityEngine.TextCore.LowLevel
{
	[Flags]
	[VisibleToOtherModules(new string[] { "UnityEngine.TextCoreTextEngineModule" })]
	internal enum GlyphRasterModes
	{
		RASTER_MODE_8BIT = 1,
		RASTER_MODE_MONO = 2,
		RASTER_MODE_NO_HINTING = 4,
		RASTER_MODE_HINTED = 8,
		RASTER_MODE_BITMAP = 0x10,
		RASTER_MODE_SDF = 0x20,
		RASTER_MODE_SDFAA = 0x40,
		RASTER_MODE_MSDF = 0x100,
		RASTER_MODE_MSDFA = 0x200,
		RASTER_MODE_1X = 0x1000,
		RASTER_MODE_8X = 0x2000,
		RASTER_MODE_16X = 0x4000,
		RASTER_MODE_32X = 0x8000,
		RASTER_MODE_COLOR = 0x10000
	}
}
