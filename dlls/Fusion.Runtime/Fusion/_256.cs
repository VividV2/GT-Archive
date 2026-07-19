using System.Runtime.InteropServices;

namespace Fusion;

[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
internal struct SimulationMessageInternal_SharedModeRequestStateAuthority
{
	public const int SIZE = 8;

	[System.Runtime.InteropServices.FieldOffset(0)]
	public NetworkId Object;

	[System.Runtime.InteropServices.FieldOffset(4)]
	public int Acquire;
}
