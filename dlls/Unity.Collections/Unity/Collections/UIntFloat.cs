using System.Runtime.InteropServices;
using Unity.Burst;
using Unity.Jobs;
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
	[StructLayout(LayoutKind.Explicit)]
	internal struct UIntFloat
	{
		[FieldOffset(0)]
		public float floatValue;

		[FieldOffset(0)]
		public uint intValue;

		[FieldOffset(0)]
		public double doubleValue;

		[FieldOffset(0)]
		public ulong longValue;
	}
}
namespace Unity.Collections
{
}
namespace Unity.Collections
{
}
