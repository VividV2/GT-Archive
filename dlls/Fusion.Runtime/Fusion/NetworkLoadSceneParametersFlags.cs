using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Fusion;

[StructLayout(LayoutKind.Explicit)]
internal struct SimulationMessageInternal_SharedModeRequestStateAuthority
{
	public const int SIZE = 8;

	[FieldOffset(0)]
	public NetworkId Object;

	[FieldOffset(4)]
	public int Acquire;
}
namespace Fusion.Statistics
{
}
namespace Fusion
{
}
namespace Fusion.LagCompensation
{
}
namespace Fusion
{
	[Flags]
	internal enum NetworkLoadSceneParametersFlags : byte
	{
		Single = 1,
		LocalPhysics2D = 2,
		LocalPhysics3D = 4,
		ActiveOnLoad = 8
	}
}
