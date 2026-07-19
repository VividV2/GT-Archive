using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Cysharp.Threading.Tasks.Internal;

internal static class StatePool<T1>
{
	private static readonly ConcurrentQueue<StateTuple<T1>> queue = new ConcurrentQueue<StateTuple<T1>>();

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static StateTuple<T1> Create(T1 item1)
	{
		if (queue.TryDequeue(out var result))
		{
			StateTuple<T1> result;
			result.Item1 = item1;
			return result;
		}
		return new StateTuple<T1>
		{
			Item1 = item1
		};
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void Return(StateTuple<T1> tuple)
	{
		tuple.Item1 = default(T1);
		queue.Enqueue(tuple);
	}
}
