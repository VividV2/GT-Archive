using Unity.Burst;
using UnityEngine;

namespace Unity.Burst.Intrinsics;

internal static class $BurstDirectCallInitializer
{
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
		BurstCompilerOptions options = BurstCompiler.Options;
	}
}
