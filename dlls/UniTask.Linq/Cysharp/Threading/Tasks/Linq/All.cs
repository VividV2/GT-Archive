using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Cysharp.Threading.Tasks.Linq
{
}
namespace Cysharp.Threading.Tasks.Linq
{
	internal static class All
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <AllAwaitAsync>d__1<TSource> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<bool> <>t__builder;

			public IUniTaskAsyncEnumerable<TSource> source;

			public CancellationToken cancellationToken;

			public Func<TSource, UniTask<bool>> predicate;

			private IUniTaskAsyncEnumerator<TSource> <e>5__2;

			private object <>7__wrap2;

			private int <>7__wrap3;

			private bool <>7__wrap4;

			private UniTask<bool>.Awaiter <>u__1;

			private UniTask.Awaiter <>u__2;

			private void MoveNext()
			{
				int num = <>1__state;
				bool result = default(bool);
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
							goto IL_01a9;
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
							if (num != 1)
							{
								goto IL_00bd;
							}
							awaiter2 = <>u__1;
							<>u__1 = default(UniTask<bool>.Awaiter);
							num = (<>1__state = -1);
							goto IL_0119;
						}
						awaiter2 = <>u__1;
						<>u__1 = default(UniTask<bool>.Awaiter);
						num = (<>1__state = -1);
						goto IL_00ab;
						IL_012c:
						<>7__wrap3 = 1;
						goto end_IL_0038;
						IL_0119:
						if (awaiter2.GetResult())
						{
							awaiter2 = predicate(<e>5__2.Current).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (<>1__state = 0);
								<>u__1 = awaiter2;
								<>t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
								return;
							}
							goto IL_00ab;
						}
						<>7__wrap4 = true;
						goto IL_012c;
						IL_00ab:
						if (awaiter2.GetResult())
						{
							goto IL_00bd;
						}
						<>7__wrap4 = false;
						goto IL_012c;
						IL_00bd:
						awaiter2 = <e>5__2.MoveNextAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (<>1__state = 1);
							<>u__1 = awaiter2;
							<>t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_0119;
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
						goto IL_01a9;
					}
					goto IL_01b0;
					IL_01a9:
					awaiter.GetResult();
					goto IL_01b0;
					IL_01b0:
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

		internal static async UniTask<bool> AllAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, bool> predicate, CancellationToken cancellationToken)
		{
			IUniTaskAsyncEnumerator<TSource> e = source.GetAsyncEnumerator(cancellationToken);
			object obj = null;
			int num = 0;
			bool result = default(bool);
			try
			{
				while (true)
				{
					if (await e.MoveNextAsync())
					{
						if (!predicate(e.Current))
						{
							result = false;
							break;
						}
						continue;
					}
					result = true;
					break;
				}
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
			bool result2 = default(bool);
			return result2;
		}

		[AsyncStateMachine(typeof(<AllAwaitAsync>d__1<>))]
		internal static UniTask<bool> AllAwaitAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			<AllAwaitAsync>d__1<TSource> stateMachine = default(<AllAwaitAsync>d__1<TSource>);
			stateMachine.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
			stateMachine.source = source;
			stateMachine.predicate = predicate;
			stateMachine.cancellationToken = cancellationToken;
			stateMachine.<>1__state = -1;
			stateMachine.<>t__builder.Start(ref stateMachine);
			return stateMachine.<>t__builder.Task;
		}

		internal static async UniTask<bool> AllAwaitWithCancellationAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, Func<TSource, CancellationToken, UniTask<bool>> predicate, CancellationToken cancellationToken)
		{
			IUniTaskAsyncEnumerator<TSource> e = source.GetAsyncEnumerator(cancellationToken);
			object obj = null;
			int num = 0;
			bool result = default(bool);
			try
			{
				while (true)
				{
					if (await e.MoveNextAsync())
					{
						if (!(await predicate(e.Current, cancellationToken)))
						{
							result = false;
							break;
						}
						continue;
					}
					result = true;
					break;
				}
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
			bool result2 = default(bool);
			return result2;
		}
	}
}
