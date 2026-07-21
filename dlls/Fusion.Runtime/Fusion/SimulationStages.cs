using System;
using System.ComponentModel;

namespace Fusion.LagCompensation
{
}
namespace Fusion
{
	[Flags]
	public enum SimulationStages
	{
		[Description("Fwrd")]
		Forward = 2,
		[Description("Resim")]
		Resimulate = 4
	}
}
