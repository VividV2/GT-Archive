using System;
using System.Threading;

namespace Cysharp.Threading.Tasks.Linq;

internal class CombineLatest<T1, T2, T3, T4, T5, TResult> : IUniTaskAsyncEnumerable<TResult>
{
	private class _CombineLatest : MoveNextSource, IUniTaskAsyncEnumerator<TResult>, IUniTaskAsyncDisposable
	{
		private static readonly Action<object> Completed1Delegate = Completed1;

		private static readonly Action<object> Completed2Delegate = Completed2;

		private static readonly Action<object> Completed3Delegate = Completed3;

		private static readonly Action<object> Completed4Delegate = Completed4;

		private static readonly Action<object> Completed5Delegate = Completed5;

		private const int CompleteCount = 5;

		private readonly IUniTaskAsyncEnumerable<T1> source1;

		private readonly IUniTaskAsyncEnumerable<T2> source2;

		private readonly IUniTaskAsyncEnumerable<T3> source3;

		private readonly IUniTaskAsyncEnumerable<T4> source4;

		private readonly IUniTaskAsyncEnumerable<T5> source5;

		private readonly Func<T1, T2, T3, T4, T5, TResult> resultSelector;

		private CancellationToken cancellationToken;

		private IUniTaskAsyncEnumerator<T1> enumerator1;

		private UniTask<bool>.Awaiter awaiter1;

		private bool hasCurrent1;

		private bool running1;

		private T1 current1;

		private IUniTaskAsyncEnumerator<T2> enumerator2;

		private UniTask<bool>.Awaiter awaiter2;

		private bool hasCurrent2;

		private bool running2;

		private T2 current2;

		private IUniTaskAsyncEnumerator<T3> enumerator3;

		private UniTask<bool>.Awaiter awaiter3;

		private bool hasCurrent3;

		private bool running3;

		private T3 current3;

		private IUniTaskAsyncEnumerator<T4> enumerator4;

		private UniTask<bool>.Awaiter awaiter4;

		private bool hasCurrent4;

		private bool running4;

		private T4 current4;

		private IUniTaskAsyncEnumerator<T5> enumerator5;

		private UniTask<bool>.Awaiter awaiter5;

		private bool hasCurrent5;

		private bool running5;

		private T5 current5;

		private int completedCount;

		private bool syncRunning;

		private TResult result;

		public TResult Current => result;

		public _CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, Func<T1, T2, T3, T4, T5, TResult> resultSelector, CancellationToken cancellationToken)
		{
			this.source1 = source1;
			this.source2 = source2;
			this.source3 = source3;
			this.source4 = source4;
			this.source5 = source5;
			this.resultSelector = resultSelector;
			this.cancellationToken = cancellationToken;
		}

		public UniTask<bool> MoveNextAsync()
		{
			cancellationToken.ThrowIfCancellationRequested();
			if (completedCount == 5)
			{
				return CompletedTasks.False;
			}
			if (enumerator1 == null)
			{
				enumerator1 = source1.GetAsyncEnumerator(cancellationToken);
				enumerator2 = source2.GetAsyncEnumerator(cancellationToken);
				enumerator3 = source3.GetAsyncEnumerator(cancellationToken);
				enumerator4 = source4.GetAsyncEnumerator(cancellationToken);
				enumerator5 = source5.GetAsyncEnumerator(cancellationToken);
			}
			completionSource.Reset();
			do
			{
				syncRunning = true;
				if (!running1)
				{
					running1 = true;
					awaiter1 = enumerator1.MoveNextAsync().GetAwaiter();
					if (awaiter1.IsCompleted)
					{
						Completed1(this);
					}
					else
					{
						awaiter1.SourceOnCompleted(Completed1Delegate, this);
					}
				}
				if (!running2)
				{
					running2 = true;
					awaiter2 = enumerator2.MoveNextAsync().GetAwaiter();
					if (awaiter2.IsCompleted)
					{
						Completed2(this);
					}
					else
					{
						awaiter2.SourceOnCompleted(Completed2Delegate, this);
					}
				}
				if (!running3)
				{
					running3 = true;
					awaiter3 = enumerator3.MoveNextAsync().GetAwaiter();
					if (awaiter3.IsCompleted)
					{
						Completed3(this);
					}
					else
					{
						awaiter3.SourceOnCompleted(Completed3Delegate, this);
					}
				}
				if (!running4)
				{
					running4 = true;
					awaiter4 = enumerator4.MoveNextAsync().GetAwaiter();
					if (awaiter4.IsCompleted)
					{
						Completed4(this);
					}
					else
					{
						awaiter4.SourceOnCompleted(Completed4Delegate, this);
					}
				}
				if (!running5)
				{
					running5 = true;
					awaiter5 = enumerator5.MoveNextAsync().GetAwaiter();
					if (awaiter5.IsCompleted)
					{
						Completed5(this);
					}
					else
					{
						awaiter5.SourceOnCompleted(Completed5Delegate, this);
					}
				}
			}
			while (!running1 || !running2 || !running3 || !running4 || !running5);
			syncRunning = false;
			return new UniTask<bool>(this, completionSource.Version);
		}

		private static void Completed1(object state)
		{
			_CombineLatest combineLatest = (_CombineLatest)state;
			combineLatest.running1 = false;
			try
			{
				if (combineLatest.awaiter1.GetResult())
				{
					combineLatest.hasCurrent1 = true;
					combineLatest.current1 = combineLatest.enumerator1.Current;
					goto IL_006f;
				}
				combineLatest.running1 = true;
				if (Interlocked.Increment(ref combineLatest.completedCount) != 5)
				{
					return;
				}
			}
			catch (Exception error)
			{
				combineLatest.running1 = true;
				combineLatest.completedCount = 5;
				combineLatest.completionSource.TrySetException(error);
				return;
			}
			combineLatest.completionSource.TrySetResult(result: false);
			return;
			IL_006f:
			if (!combineLatest.TrySetResult() && !combineLatest.syncRunning)
			{
				combineLatest.running1 = true;
				try
				{
					combineLatest.awaiter1 = combineLatest.enumerator1.MoveNextAsync().GetAwaiter();
				}
				catch (Exception error2)
				{
					combineLatest.completedCount = 5;
					combineLatest.completionSource.TrySetException(error2);
					return;
				}
				combineLatest.awaiter1.SourceOnCompleted(Completed1Delegate, combineLatest);
			}
		}

		private static void Completed2(object state)
		{
			_CombineLatest combineLatest = (_CombineLatest)state;
			combineLatest.running2 = false;
			try
			{
				if (combineLatest.awaiter2.GetResult())
				{
					combineLatest.hasCurrent2 = true;
					combineLatest.current2 = combineLatest.enumerator2.Current;
					goto IL_006f;
				}
				combineLatest.running2 = true;
				if (Interlocked.Increment(ref combineLatest.completedCount) != 5)
				{
					return;
				}
			}
			catch (Exception error)
			{
				combineLatest.running2 = true;
				combineLatest.completedCount = 5;
				combineLatest.completionSource.TrySetException(error);
				return;
			}
			combineLatest.completionSource.TrySetResult(result: false);
			return;
			IL_006f:
			if (!combineLatest.TrySetResult() && !combineLatest.syncRunning)
			{
				combineLatest.running2 = true;
				try
				{
					combineLatest.awaiter2 = combineLatest.enumerator2.MoveNextAsync().GetAwaiter();
				}
				catch (Exception error2)
				{
					combineLatest.completedCount = 5;
					combineLatest.completionSource.TrySetException(error2);
					return;
				}
				combineLatest.awaiter2.SourceOnCompleted(Completed2Delegate, combineLatest);
			}
		}

		private static void Completed3(object state)
		{
			_CombineLatest combineLatest = (_CombineLatest)state;
			combineLatest.running3 = false;
			try
			{
				if (combineLatest.awaiter3.GetResult())
				{
					combineLatest.hasCurrent3 = true;
					combineLatest.current3 = combineLatest.enumerator3.Current;
					goto IL_006f;
				}
				combineLatest.running3 = true;
				if (Interlocked.Increment(ref combineLatest.completedCount) != 5)
				{
					return;
				}
			}
			catch (Exception error)
			{
				combineLatest.running3 = true;
				combineLatest.completedCount = 5;
				combineLatest.completionSource.TrySetException(error);
				return;
			}
			combineLatest.completionSource.TrySetResult(result: false);
			return;
			IL_006f:
			if (!combineLatest.TrySetResult() && !combineLatest.syncRunning)
			{
				combineLatest.running3 = true;
				try
				{
					combineLatest.awaiter3 = combineLatest.enumerator3.MoveNextAsync().GetAwaiter();
				}
				catch (Exception error2)
				{
					combineLatest.completedCount = 5;
					combineLatest.completionSource.TrySetException(error2);
					return;
				}
				combineLatest.awaiter3.SourceOnCompleted(Completed3Delegate, combineLatest);
			}
		}

		private static void Completed4(object state)
		{
			_CombineLatest combineLatest = (_CombineLatest)state;
			combineLatest.running4 = false;
			try
			{
				if (combineLatest.awaiter4.GetResult())
				{
					combineLatest.hasCurrent4 = true;
					combineLatest.current4 = combineLatest.enumerator4.Current;
					goto IL_006f;
				}
				combineLatest.running4 = true;
				if (Interlocked.Increment(ref combineLatest.completedCount) != 5)
				{
					return;
				}
			}
			catch (Exception error)
			{
				combineLatest.running4 = true;
				combineLatest.completedCount = 5;
				combineLatest.completionSource.TrySetException(error);
				return;
			}
			combineLatest.completionSource.TrySetResult(result: false);
			return;
			IL_006f:
			if (!combineLatest.TrySetResult() && !combineLatest.syncRunning)
			{
				combineLatest.running4 = true;
				try
				{
					combineLatest.awaiter4 = combineLatest.enumerator4.MoveNextAsync().GetAwaiter();
				}
				catch (Exception error2)
				{
					combineLatest.completedCount = 5;
					combineLatest.completionSource.TrySetException(error2);
					return;
				}
				combineLatest.awaiter4.SourceOnCompleted(Completed4Delegate, combineLatest);
			}
		}

		private static void Completed5(object state)
		{
			_CombineLatest combineLatest = (_CombineLatest)state;
			combineLatest.running5 = false;
			try
			{
				if (combineLatest.awaiter5.GetResult())
				{
					combineLatest.hasCurrent5 = true;
					combineLatest.current5 = combineLatest.enumerator5.Current;
					goto IL_006f;
				}
				combineLatest.running5 = true;
				if (Interlocked.Increment(ref combineLatest.completedCount) != 5)
				{
					return;
				}
			}
			catch (Exception error)
			{
				combineLatest.running5 = true;
				combineLatest.completedCount = 5;
				combineLatest.completionSource.TrySetException(error);
				return;
			}
			combineLatest.completionSource.TrySetResult(result: false);
			return;
			IL_006f:
			if (!combineLatest.TrySetResult() && !combineLatest.syncRunning)
			{
				combineLatest.running5 = true;
				try
				{
					combineLatest.awaiter5 = combineLatest.enumerator5.MoveNextAsync().GetAwaiter();
				}
				catch (Exception error2)
				{
					combineLatest.completedCount = 5;
					combineLatest.completionSource.TrySetException(error2);
					return;
				}
				combineLatest.awaiter5.SourceOnCompleted(Completed5Delegate, combineLatest);
			}
		}

		private bool TrySetResult()
		{
			if (hasCurrent1 && hasCurrent2 && hasCurrent3 && hasCurrent4 && hasCurrent5)
			{
				result = resultSelector(current1, current2, current3, current4, current5);
				completionSource.TrySetResult(result: true);
				return true;
			}
			return false;
		}

		public async UniTask DisposeAsync()
		{
			if (enumerator1 != null)
			{
				await enumerator1.DisposeAsync();
			}
			if (enumerator2 != null)
			{
				await enumerator2.DisposeAsync();
			}
			if (enumerator3 != null)
			{
				await enumerator3.DisposeAsync();
			}
			if (enumerator4 != null)
			{
				await enumerator4.DisposeAsync();
			}
			if (enumerator5 != null)
			{
				await enumerator5.DisposeAsync();
			}
		}
	}

	private readonly IUniTaskAsyncEnumerable<T1> source1;

	private readonly IUniTaskAsyncEnumerable<T2> source2;

	private readonly IUniTaskAsyncEnumerable<T3> source3;

	private readonly IUniTaskAsyncEnumerable<T4> source4;

	private readonly IUniTaskAsyncEnumerable<T5> source5;

	private readonly Func<T1, T2, T3, T4, T5, TResult> resultSelector;

	public CombineLatest(IUniTaskAsyncEnumerable<T1> source1, IUniTaskAsyncEnumerable<T2> source2, IUniTaskAsyncEnumerable<T3> source3, IUniTaskAsyncEnumerable<T4> source4, IUniTaskAsyncEnumerable<T5> source5, Func<T1, T2, T3, T4, T5, TResult> resultSelector)
	{
		this.source1 = source1;
		this.source2 = source2;
		this.source3 = source3;
		this.source4 = source4;
		this.source5 = source5;
		this.resultSelector = resultSelector;
	}

	public IUniTaskAsyncEnumerator<TResult> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken))
	{
		return new _CombineLatest(source1, source2, source3, source4, source5, resultSelector, cancellationToken);
	}
}
