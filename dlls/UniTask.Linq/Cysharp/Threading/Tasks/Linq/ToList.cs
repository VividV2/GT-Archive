using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class ToList
	{
		internal static async UniTask<List<TSource>> ToListAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			List<TSource> list = new List<TSource>();
			IUniTaskAsyncEnumerable<TSource> uniTaskAsyncEnumerable = default(IUniTaskAsyncEnumerable<TSource>);
			CancellationToken cancellationToken2 = default(CancellationToken);
			IUniTaskAsyncEnumerator<TSource> e = uniTaskAsyncEnumerable.GetAsyncEnumerator(cancellationToken2);
			object obj = null;
			try
			{
				while (await e.MoveNextAsync())
				{
					list.Add(e.Current);
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
			return list;
		}
	}
}
namespace Cysharp.Threading.Tasks.Linq
{
}
