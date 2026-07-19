using System;
using System;
using System;

namespace UnityEngine.Rendering;

[Flags]
public enum FoveatedRenderingCaps
{
	None = 0,
	FoveationImage = 1,
	NonUniformRaster = 2,
	ModeChangeOnlyBeforeRenderTargetSet = 4
}
namespace UnityEngine.Rendering
{
	public enum GraphicsTier
	{
		Tier1,
		Tier2,
		Tier3
	}
}
