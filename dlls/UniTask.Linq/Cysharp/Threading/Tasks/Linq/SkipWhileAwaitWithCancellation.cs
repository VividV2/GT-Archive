using System;
using System.Collections.Generic;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq;

internal sealed class Intersect<TSource>(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer) : IUniTaskAsyncEnumerable<TSource>
{
	private class _Intersect(IUniTaskAsyncEnumerable<TSource> first, IUniTaskAsyncEnumerable<TSource> second, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken) : AsyncEnumeratorBase<TSource, TSource>(first, cancellationToken)
	{
		private static Action<object> HashSetAsyncCoreDelegate = HashSetAsyncCore;

		private readonly IEqualityComparer<TSource> comparer = comparer;

		private readonly IUniTaskAsyncEnumerable<TSource> second = second;

		private HashSet<TSource> set;

		private UniTask<HashSet<TSource>>.Awaiter awaiter;

		protected override bool OnFirstIteration()
		{
			if (set != null)
			{
				return false;
			}
			awaiter = second.ToHashSetAsync(cancellationToken).GetAwaiter();
			if (awaiter.IsCompleted)
			{
				set = awaiter.GetResult();
				SourceMoveNext();
			}
			else
			{
				awaiter.SourceOnCompleted(HashSetAsyncCoreDelegate, this);
			}
			return true;
		}

		private static void HashSetAsyncCore(object state)
		{
			_Intersect intersect = (_Intersect)state;
			_Intersect intersect;
			if (intersect.TryGetResult(intersect.awaiter, out var result))
			{
				HashSet<TSource> result;
				intersect.set = result;
				intersect.SourceMoveNext();
			}
		}

		protected override bool TryMoveNextCore(bool sourceHasCurrent, out bool result)
		{
			if (sourceHasCurrent)
			{
				TSource sourceCurrent = base.SourceCurrent;
				TSource sourceCurrent;
				if (set.Remove(sourceCurrent))
				{
					base.Current = sourceCurrent;
					result = true;
					return true;
				}
				result = false;
				return false;
			}
			result = false;
			return true;
		}
	}

	private readonly IUniTaskAsyncEnumerable<TSource> first = first;

	private readonly IUniTaskAsyncEnumerable<TSource> second = second;

	private readonly IEqualityComparer<TSource> comparer = comparer;

	public IUniTaskAsyncEnumerator<TSource> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
	{
		return new _Intersect(first, second, comparer, cancellationToken);
	}
}
