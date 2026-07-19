using System;
using System.Collections.Generic;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal class OrderedAsyncEnumerable<TElement, TKey>(IUniTaskAsyncEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, OrderedAsyncEnumerable<TElement> parent) : OrderedAsyncEnumerable<TElement>(source)
	{
		private readonly Func<TElement, TKey> keySelector = keySelector;

		private readonly IComparer<TKey> comparer = comparer;

		private readonly bool descending = descending;

		private readonly OrderedAsyncEnumerable<TElement> parent = parent;

		internal override AsyncEnumerableSorter<TElement> GetAsyncEnumerableSorter(AsyncEnumerableSorter<TElement> next, CancellationToken cancellationToken)
		{
			AsyncEnumerableSorter<TElement> asyncEnumerableSorter = new SyncSelectorAsyncEnumerableSorter<TElement, TKey>(keySelector, comparer, descending, next);
			AsyncEnumerableSorter<TElement> asyncEnumerableSorter;
			if (parent != null)
			{
				asyncEnumerableSorter = parent.GetAsyncEnumerableSorter(asyncEnumerableSorter, cancellationToken);
			}
			return asyncEnumerableSorter;
		}
	}
}
namespace Cysharp.Threading.Tasks.Linq
{
}
