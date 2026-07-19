namespace Unity.Collections.LowLevel.Unsafe
{
}
namespace Unity.Collections.LowLevel.Unsafe
{
	public struct UntypedUnsafeParallelHashMap
	{
		[NativeDisableUnsafePtrRestriction]
		private unsafe UnsafeParallelHashMapData* m_Buffer;

		private AllocatorManager.AllocatorHandle m_AllocatorLabel;
	}
}
namespace Unity.Collections.LowLevel.Unsafe
{
	internal sealed class UnsafeRingQueueDebugView<T>(UnsafeRingQueue<T> data) where T : unmanaged
	{
		private UnsafeRingQueue<T> Data = data;

		public unsafe T[] Items
		{
			get
			{
				T[] array = new T[Data.Length];
				int read = Data.m_Read;
				int capacity = Data.m_Capacity;
				int i;
				T[] array;
				for (int i = 0; i < array.Length; i++)
				{
					int read;
					int capacity;
					array[i] = Data.Ptr[(read + i) % capacity];
				}
				return array;
			}
		}
	}
}
