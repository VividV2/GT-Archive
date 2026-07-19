using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
}
namespace Cysharp.Threading.Tasks.Linq
{
	internal static class ToHashSet
	{
		internal static async UniTask<HashSet<TSource>> ToHashSetAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, IEqualityComparer<TSource> comparer, CancellationToken cancellationToken)
		{
			IEqualityComparer<TSource> comparer2 = default(IEqualityComparer<TSource>);
			HashSet<TSource> set = new HashSet<TSource>(comparer2);
			IUniTaskAsyncEnumerable<TSource> uniTaskAsyncEnumerable = default(IUniTaskAsyncEnumerable<TSource>);
			CancellationToken cancellationToken2 = default(CancellationToken);
			IUniTaskAsyncEnumerator<TSource> e = uniTaskAsyncEnumerable.GetAsyncEnumerator(cancellationToken2);
			object obj = null;
			try
			{
				while (await e.MoveNextAsync())
				{
					set.Add(e.Current);
				}
			}
			catch (object obj2)
			{
				obj = obj2;
			}
			if (e != null)
			{
				await e.DisposeAsync();
			}
			object obj3 = obj;
			if (obj3 != null)
			{
				ExceptionDispatchInfo.Capture((obj3 as Exception) ?? throw obj3).Throw();
			}
			return set;
		}
	}
}
