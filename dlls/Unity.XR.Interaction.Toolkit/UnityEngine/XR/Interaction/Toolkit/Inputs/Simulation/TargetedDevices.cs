using System;
using System;

namespace UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Theme.Primitives
{
	[Obsolete("The Affordance System namespace and all associated classes have been deprecated. The existing affordance system will be moved, replaced and updated with a new interaction feedback system in a future version of XRI.")]
	public enum ColorBlendMode : byte
	{
		Solid,
		Add,
		Mix
	}
}
namespace UnityEngine.XR.Interaction.Toolkit.Inputs.Simulation
{
	[Flags]
	public enum TargetedDevices
	{
		None = 0,
		FPS = 1,
		LeftDevice = 2,
		RightDevice = 4,
		HMD = 8
	}
}
