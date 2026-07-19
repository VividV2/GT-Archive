using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace Fusion.LagCompensation
{
	public delegate void PreProcessingDelegate(Query query, HashSet<HitboxRoot> rootCandidates, HashSet<int> processedColliderIndices);
}
namespace Fusion
{
	internal static class ICallbacksExtensions
	{
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("FUSION_UNITY")]
		public static void InvokeOnInput(this Simulation.ICallbacks callbacks, SimulationInput input)
		{
			callbacks.OnInput(input);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[Conditional("FUSION_UNITY")]
		public static void InvokeOnInputMissing(this Simulation.ICallbacks callbacks, SimulationInput input)
		{
			callbacks.OnInputMissing(input);
		}
	}
}
