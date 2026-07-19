using System;
using System.Collections.Generic;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnAnimatorMoveHandler
	{
		UniTask OnAnimatorMoveAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnDrawGizmosHandler
	{
		UniTask OnDrawGizmosAsync();
	}
}
namespace Cysharp.Threading.Tasks
{
	public interface IUniTaskOrderedAsyncEnumerable<TElement> : IUniTaskAsyncEnumerable<TElement>
	{
		IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending);

		IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, UniTask<TKey>> keySelector, IComparer<TKey> comparer, bool descending);

		IUniTaskOrderedAsyncEnumerable<TElement> CreateOrderedEnumerable<TKey>(Func<TElement, CancellationToken, UniTask<TKey>> keySelector, IComparer<TKey> comparer, bool descending);
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
}
namespace Cysharp.Threading.Tasks
{
}
namespace Cysharp.Threading.Tasks
{
	public interface ITriggerHandler<T>
	{
		ITriggerHandler<T> Prev { get; set; }

		ITriggerHandler<T> Next { get; set; }

		void OnNext(T value);

		void OnError(Exception ex);

		void OnCompleted();

		void OnCanceled(CancellationToken cancellationToken);
	}
}
