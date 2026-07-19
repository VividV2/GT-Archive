using Unity.Burst;
using UnityEngine;

namespace Unity.Collections.LowLevel.Unsafe
{
	[GenerateTestsForBurstCompatibility]
	internal struct UnsafeStreamBlock
	{
		internal unsafe UnsafeStreamBlock* Next;

		internal unsafe fixed byte Data[1];
	}
}
namespace Unity.Collections.LowLevel.Unsafe
{
}
internal static class $BurstDirectCallInitializer
{
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterAssembliesLoaded)]
	private static void Initialize()
	{
		BurstCompilerOptions options = BurstCompiler.Options;
	}
}
