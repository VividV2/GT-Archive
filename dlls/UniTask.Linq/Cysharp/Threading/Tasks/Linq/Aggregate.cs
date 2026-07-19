using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks.CompilerServices;
using Cysharp.Threading.Tasks.Internal;

namespace Cysharp.Threading.Tasks.Linq;

internal static class Aggregate
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <AggregateAsync>d__0<TSource> : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<TSource> <>t__builder;

		public IUniTaskAsyncEnumerable<TSource> source;

		public CancellationToken cancellationToken;

		public Func<TSource, TSource, TSource> accumulator;

		private IUniTaskAsyncEnumerator<TSource> <e>5__2;

		private object <>7__wrap2;

		private int <>7__wrap3;

		private TSource <>7__wrap4;

		private TSource <value>5__6;

		private UniTask<bool>.Awaiter <>u__1;

		private UniTask.Awaiter <>u__2;

		private void MoveNext()
		{
			int num = <>1__state;
			TSource result = default(TSource);
			try
			{
				UniTask.Awaiter awaiter;
				if ((uint)num > 1u)
				{
					if (num == 2)
					{
						awaiter = <>u__2;
						<>u__2 = default(UniTask.Awaiter);
						num = (<>1__state = -1);
						goto IL_01d3;
					}
					<e>5__2 = source.GetAsyncEnumerator(cancellationToken);
					<>7__wrap2 = null;
					<>7__wrap3 = 0;
				}
				try
				{
					UniTask<bool>.Awaiter awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter2 = <>u__1;
							<>u__1 = default(UniTask<bool>.Awaiter);
							num = (<>1__state = -1);
							goto IL_013e;
						}
						awaiter2 = <e>5__2.MoveNextAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (<>1__state = 0);
							<>u__1 = awaiter2;
							<>t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = <>u__1;
						<>u__1 = default(UniTask<bool>.Awaiter);
						num = (<>1__state = -1);
					}
					if (awaiter2.GetResult())
					{
						<value>5__6 = <e>5__2.Current;
						goto IL_00e2;
					}
					throw Error.NoElements();
					IL_013e:
					if (awaiter2.GetResult())
					{
						<value>5__6 = accumulator(<value>5__6, <e>5__2.Current);
						goto IL_00e2;
					}
					<>7__wrap4 = <value>5__6;
					<>7__wrap3 = 1;
					goto end_IL_0038;
					IL_00e2:
					awaiter2 = <e>5__2.MoveNextAsync().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (<>1__state = 1);
						<>u__1 = awaiter2;
						<>t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						return;
					}
					goto IL_013e;
					end_IL_0038:;
				}
				catch (object obj)
				{
					<>7__wrap2 = obj;
				}
				if (<e>5__2 != null)
				{
					awaiter = <e>5__2.DisposeAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (<>1__state = 2);
						<>u__2 = awaiter;
						<>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						return;
					}
					goto IL_01d3;
				}
				goto IL_01da;
				IL_01d3:
				awaiter.GetResult();
				goto IL_01da;
				IL_01da:
				object obj2 = <>7__wrap2;
				if (obj2 != null)
				{
					ExceptionDispatchInfo.Capture((obj2 as Exception) ?? throw obj2).Throw();
				}
				int num2 = <>7__wrap3;
				if (num2 == 1)
				{
					result = <>7__wrap4;
				}
				else
				{
					<>7__wrap2 = null;
					<>7__wrap4 = default(TSource);
					<e>5__2 = null;
				}
			}
			catch (Exception exception)
			{
				<>1__state = -2;
				<e>5__2 = null;
				<>t__builder.SetException(exception);
				return;
			}
			<>1__state = -2;
			<e>5__2 = null;
			<>t__builder.SetResult(result);
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			<>t__builder.SetStateMachine(stateMachine);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	internal unsafe static async UniTask<TSource> AggregateAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, TSource> accumulator, CancellationToken cancellationToken)
	{
		IUniTaskAsyncEnumerable<TSource> uniTaskAsyncEnumerable = default(IUniTaskAsyncEnumerable<TSource>);
		CancellationToken cancellationToken2 = default(CancellationToken);
		IUniTaskAsyncEnumerator<TSource> e = uniTaskAsyncEnumerable.GetAsyncEnumerator(cancellationToken2);
		object obj = null;
		int num = 0;
		AsyncUniTaskMethodBuilder<TSource> asyncUniTaskMethodBuilder = default(AsyncUniTaskMethodBuilder<TSource>);
		TSource result = default(TSource);
		try
		{
			UniTask<bool>.Awaiter awaiter = e.MoveNextAsync().GetAwaiter();
			if (!awaiter.IsCompleted)
			{
				asyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref *(<AggregateAsync>d__0<TSource>*)/*Error near IL_0077: stateMachine*/);
				return;
			}
			if (!awaiter.GetResult())
			{
				throw Error.NoElements();
			}
			TSource value = e.Current;
			Func<TSource, TSource, TSource> func = default(Func<TSource, TSource, TSource>);
			while (true)
			{
				awaiter = e.MoveNextAsync().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					asyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref *(<AggregateAsync>d__0<TSource>*)/*Error near IL_0117: stateMachine*/);
					return;
				}
				if (!awaiter.GetResult())
				{
					break;
				}
				value = func(value, e.Current);
			}
			result = value;
			num = 1;
		}
		catch (object obj2)
		{
			obj = obj2;
		}
		if (e != null)
		{
			UniTask.Awaiter awaiter2 = e.DisposeAsync().GetAwaiter();
			if (!awaiter2.IsCompleted)
			{
				asyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref *(<AggregateAsync>d__0<TSource>*)/*Error near IL_01ab: stateMachine*/);
				return;
			}
			awaiter2.GetResult();
		}
		object obj3 = obj;
		if (obj3 != null)
		{
			ExceptionDispatchInfo.Capture((obj3 as Exception) ?? throw obj3).Throw();
		}
		if (num == 1)
		{
			return result;
		}
		TSource result2 = default(TSource);
		return result2;
	}

	internal static async UniTask<TAccumulate> AggregateAsync<TSource, TAccumulate>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, CancellationToken cancellationToken)
	{
		IUniTaskAsyncEnumerator<TSource> e = source.GetAsyncEnumerator(cancellationToken);
		object obj = null;
		int num = 0;
		TAccumulate result = default(TAccumulate);
		try
		{
			TAccumulate value = seed;
			while (await e.MoveNextAsync())
			{
				value = accumulator(value, e.Current);
			}
			result = value;
			num = 1;
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
		if (num == 1)
		{
			return result;
		}
		TAccumulate result2 = default(TAccumulate);
		return result2;
	}

	internal static async UniTask<TResult> AggregateAsync<TSource, TAccumulate, TResult>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, TAccumulate> accumulator, Func<TAccumulate, TResult> resultSelector, CancellationToken cancellationToken)
	{
		IUniTaskAsyncEnumerator<TSource> e = source.GetAsyncEnumerator(cancellationToken);
		object obj = null;
		int num = 0;
		TResult result = default(TResult);
		try
		{
			TAccumulate value = seed;
			while (await e.MoveNextAsync())
			{
				value = accumulator(value, e.Current);
			}
			result = resultSelector(value);
			num = 1;
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
		if (num == 1)
		{
			return result;
		}
		TResult result2 = default(TResult);
		return result2;
	}

	internal static async UniTask<TSource> AggregateAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, UniTask<TSource>> accumulator, CancellationToken cancellationToken)
	{
		IUniTaskAsyncEnumerable<TSource> uniTaskAsyncEnumerable = default(IUniTaskAsyncEnumerable<TSource>);
		CancellationToken cancellationToken2 = default(CancellationToken);
		IUniTaskAsyncEnumerator<TSource> e = uniTaskAsyncEnumerable.GetAsyncEnumerator(cancellationToken2);
		object obj = null;
		int num = 0;
		TSource result = default(TSource);
		try
		{
			if (!(await e.MoveNextAsync()))
			{
				throw Error.NoElements();
			}
			TSource value = e.Current;
			Func<TSource, TSource, UniTask<TSource>> func = default(Func<TSource, TSource, UniTask<TSource>>);
			while (await e.MoveNextAsync())
			{
				value = await func(value, e.Current);
			}
			result = value;
			num = 1;
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
		if (num == 1)
		{
			return result;
		}
		TSource result2 = default(TSource);
		return result2;
	}

	internal static async UniTask<TAccumulate> AggregateAwaitAsync<TSource, TAccumulate>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, UniTask<TAccumulate>> accumulator, CancellationToken cancellationToken)
	{
		IUniTaskAsyncEnumerator<TSource> e = source.GetAsyncEnumerator(cancellationToken);
		object obj = null;
		int num = 0;
		TAccumulate result = default(TAccumulate);
		try
		{
			TAccumulate value = seed;
			while (await e.MoveNextAsync())
			{
				value = await accumulator(value, e.Current);
			}
			result = value;
			num = 1;
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
		if (num == 1)
		{
			return result;
		}
		TAccumulate result2 = default(TAccumulate);
		return result2;
	}

	internal static async UniTask<TResult> AggregateAwaitAsync<TSource, TAccumulate, TResult>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, UniTask<TAccumulate>> accumulator, Func<TAccumulate, UniTask<TResult>> resultSelector, CancellationToken cancellationToken)
	{
		IUniTaskAsyncEnumerator<TSource> e = source.GetAsyncEnumerator(cancellationToken);
		object obj = null;
		int num = 0;
		TResult result = default(TResult);
		try
		{
			TAccumulate value = seed;
			while (await e.MoveNextAsync())
			{
				value = await accumulator(value, e.Current);
			}
			result = await resultSelector(value);
			num = 1;
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
		if (num == 1)
		{
			return result;
		}
		TResult result2 = default(TResult);
		return result2;
	}

	internal static async UniTask<TSource> AggregateAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, TSource, CancellationToken, UniTask<TSource>> accumulator, CancellationToken cancellationToken)
	{
		IUniTaskAsyncEnumerator<TSource> e = source.GetAsyncEnumerator(cancellationToken);
		object obj = null;
		int num = 0;
		TSource result = default(TSource);
		try
		{
			if (!(await e.MoveNextAsync()))
			{
				throw Error.NoElements();
			}
			TSource value = e.Current;
			while (await e.MoveNextAsync())
			{
				value = await accumulator(value, e.Current, cancellationToken);
			}
			result = value;
			num = 1;
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
		if (num == 1)
		{
			return result;
		}
		TSource result2 = default(TSource);
		return result2;
	}

	internal static async UniTask<TAccumulate> AggregateAwaitWithCancellationAsync<TSource, TAccumulate>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, CancellationToken, UniTask<TAccumulate>> accumulator, CancellationToken cancellationToken)
	{
		IUniTaskAsyncEnumerator<TSource> e = source.GetAsyncEnumerator(cancellationToken);
		object obj = null;
		int num = 0;
		TAccumulate result = default(TAccumulate);
		try
		{
			TAccumulate value = seed;
			while (await e.MoveNextAsync())
			{
				value = await accumulator(value, e.Current, cancellationToken);
			}
			result = value;
			num = 1;
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
		if (num == 1)
		{
			return result;
		}
		TAccumulate result2 = default(TAccumulate);
		return result2;
	}

	internal static async UniTask<TResult> AggregateAwaitWithCancellationAsync<TSource, TAccumulate, TResult>(IUniTaskAsyncEnumerable<TSource> source, TAccumulate seed, Func<TAccumulate, TSource, CancellationToken, UniTask<TAccumulate>> accumulator, Func<TAccumulate, CancellationToken, UniTask<TResult>> resultSelector, CancellationToken cancellationToken)
	{
		IUniTaskAsyncEnumerator<TSource> e = source.GetAsyncEnumerator(cancellationToken);
		object obj = null;
		int num = 0;
		TResult result = default(TResult);
		try
		{
			TAccumulate value = seed;
			while (await e.MoveNextAsync())
			{
				value = await accumulator(value, e.Current, cancellationToken);
			}
			result = await resultSelector(value, cancellationToken);
			num = 1;
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
		if (num == 1)
		{
			return result;
		}
		TResult result2 = default(TResult);
		return result2;
	}
}
