using System;

namespace Fusion;

internal struct NetworkObjectPacketData
{
	public NetworkId Id;

	public Tick ResetTick;

	public NetworkObjectPacketFlags Flags;
}
namespace Fusion
{
	[AttributeUsage(AttributeTargets.Parameter)]
	public class RpcTargetAttribute : Attribute
	{
	}
}
