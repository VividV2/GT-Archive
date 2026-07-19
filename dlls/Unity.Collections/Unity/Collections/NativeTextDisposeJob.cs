using Unity.Burst;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections
{
	[BurstCompile]
	internal struct NativeTextDisposeJob : IJob
	{
		public NativeTextDispose Data;

		public void Execute()
		{
			Data.Dispose();
		}
	}
}
namespace Unity.Collections
{
	[Unity.Collections.LowLevel.Unsafe.NativeContainer]
	[GenerateTestsForBurstCompatibility]
	internal struct NativeTextDispose
	{
		[Unity.Collections.LowLevel.Unsafe.NativeDisableUnsafePtrRestriction]
		public unsafe Unity.Collections.LowLevel.Unsafe.UnsafeText* m_TextData;

		public unsafe void Dispose()
		{
			Unity.Collections.LowLevel.Unsafe.UnsafeText.Free(m_TextData);
		}
	}
}
namespace Unity.Collections
{
}
