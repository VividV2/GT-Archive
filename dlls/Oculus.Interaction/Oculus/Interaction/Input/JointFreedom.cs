using System;
using UnityEngine;
using System;
using UnityEngine;

namespace Oculus.Interaction.Input
{
	public interface IHmd
	{
		event Action WhenUpdated;

		bool TryGetRootPose(out Pose pose);
	}
}
namespace Oculus.Interaction.Input.Visuals
{
}
namespace Oculus.Interaction.Input
{
	public enum JointFreedom
	{
		Free,
		Constrained,
		Locked
	}
}
namespace Oculus.Interaction
{
}
