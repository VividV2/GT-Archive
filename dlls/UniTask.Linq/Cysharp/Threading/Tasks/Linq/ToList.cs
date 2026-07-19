using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Cysharp.Threading.Tasks.Linq
{
	internal static class ToList
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <ToListAsync>d__0<TSource> : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<List<TSource>> <>t__builder;

			public IUniTaskAsyncEnumerable<TSource> source;

			public CancellationToken cancellationToken;

			private List<TSource> <list>5__2;

			private IUniTaskAsyncEnumerator<TSource> <e>5__3;

			private object <>7__wrap3;

			private int <>7__wrap4;

			private UniTask<bool>.Awaiter <>u__1;

			private UniTask.Awaiter <>u__2;

			private void MoveNext()
			{
				int num = <>1__state;
				List<TSource> result;
				try
				{
					UniTask.Awaiter awaiter;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = <>u__2;
							<>u__2 = default(UniTask.Awaiter);
							num = (<>1__state = -1);
							goto IL_0138;
						}
						<list>5__2 = new List<TSource>();
						<e>5__3 = source.GetAsyncEnumerator(cancellationToken);
						<>7__wrap3 = null;
						<>7__wrap4 = 0;
					}
					try
					{
						if (num != 0)
						{
							goto IL_005d;
						}
						UniTask<bool>.Awaiter awaiter2 = <>u__1;
						<>u__1 = default(UniTask<bool>.Awaiter);
						num = (<>1__state = -1);
						goto IL_00b9;
						IL_00b9:
						if (awaiter2.GetResult())
						{
							<list>5__2.Add(<e>5__3.Current);
							goto IL_005d;
						}
						goto end_IL_0042;
						IL_005d:
						awaiter2 = <e>5__3.MoveNextAsync().GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (<>1__state = 0);
							<>u__1 = awaiter2;
							<>t__builder.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
							return;
						}
						goto IL_00b9;
						end_IL_0042:;
					}
					catch (object obj)
					{
						<>7__wrap3 = obj;
					}
					if (<e>5__3 != null)
					{
						awaiter = <e>5__3.DisposeAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (<>1__state = 1);
							<>u__2 = awaiter;
							<>t__builder.AwaitUnsafeOnCompleted(ref awaiter, ref this);
							return;
						}
						goto IL_0138;
					}
					goto IL_013f;
					IL_0138:
					awaiter.GetResult();
					goto IL_013f;
					IL_013f:
					object obj2 = <>7__wrap3;
					if (obj2 != null)
					{
						ExceptionDispatchInfo.Capture((obj2 as Exception) ?? throw obj2).Throw();
					}
					<>7__wrap3 = null;
					result = <list>5__2;
				}
				catch (Exception exception)
				{
					<>1__state = -2;
					<list>5__2 = null;
					<e>5__3 = null;
					<>t__builder.SetException(exception);
					return;
				}
				<>1__state = -2;
				<list>5__2 = null;
				<e>5__3 = null;
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

		internal unsafe static async UniTask<List<TSource>> ToListAsync<TSource>(IUniTaskAsyncEnumerable<TSource> source, CancellationToken cancellationToken)
		{
			List<TSource> list = new List<TSource>();
			IUniTaskAsyncEnumerable<TSource> uniTaskAsyncEnumerable = default(IUniTaskAsyncEnumerable<TSource>);
			CancellationToken cancellationToken2 = default(CancellationToken);
			IUniTaskAsyncEnumerator<TSource> e = uniTaskAsyncEnumerable.GetAsyncEnumerator(cancellationToken2);
			object obj = null;
			AsyncUniTaskMethodBuilder<List<TSource>> asyncUniTaskMethodBuilder = default(AsyncUniTaskMethodBuilder<List<TSource>>);
			try
			{
				while (true)
				{
					UniTask<bool>.Awaiter awaiter = e.MoveNextAsync().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						asyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted(ref awaiter, ref *(<ToListAsync>d__0<TSource>*)/*Error near IL_0092: stateMachine*/);
						return;
					}
					if (awaiter.GetResult())
					{
						list.Add(e.Current);
						continue;
					}
					break;
				}
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
					asyncUniTaskMethodBuilder.AwaitUnsafeOnCompleted(ref awaiter2, ref *(<ToListAsync>d__0<TSource>*)/*Error near IL_0110: stateMachine*/);
					return;
				}
				awaiter2.GetResult();
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
