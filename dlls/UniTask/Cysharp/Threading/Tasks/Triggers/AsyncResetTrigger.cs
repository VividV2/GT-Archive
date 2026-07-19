using System.Threading;
using UnityEngine;
using System.Threading;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers;

[DisallowMultipleComponent]
public sealed class AsyncRectTransformRemovedTrigger : AsyncTriggerBase<AsyncUnit>
{
	private void OnRectTransformRemoved()
	{
		RaiseEvent(AsyncUnit.Default);
	}

	public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler()
	{
		return new AsyncTriggerHandler<AsyncUnit>(this, callOnce: false);
	}

	public IAsyncOnRectTransformRemovedHandler GetOnRectTransformRemovedAsyncHandler(CancellationToken cancellationToken)
	{
		return new AsyncTriggerHandler<AsyncUnit>(this, cancellationToken, callOnce: false);
	}

	public UniTask OnRectTransformRemovedAsync()
	{
		return ((IAsyncOnRectTransformRemovedHandler)new AsyncTriggerHandler<AsyncUnit>(this, callOnce: true)).OnRectTransformRemovedAsync();
	}

	public UniTask OnRectTransformRemovedAsync(CancellationToken cancellationToken)
	{
		return ((IAsyncOnRectTransformRemovedHandler)new AsyncTriggerHandler<AsyncUnit>(this, cancellationToken, callOnce: true)).OnRectTransformRemovedAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	[DisallowMultipleComponent]
	public sealed class AsyncResetTrigger : AsyncTriggerBase<AsyncUnit>
	{
		private void Reset()
		{
			RaiseEvent(AsyncUnit.Default);
		}

		public IAsyncResetHandler GetResetAsyncHandler()
		{
			return new AsyncTriggerHandler<AsyncUnit>(this, callOnce: false);
		}

		public IAsyncResetHandler GetResetAsyncHandler(CancellationToken cancellationToken)
		{
			return new AsyncTriggerHandler<AsyncUnit>(this, cancellationToken, callOnce: false);
		}

		public UniTask ResetAsync()
		{
			return ((IAsyncResetHandler)new AsyncTriggerHandler<AsyncUnit>(this, callOnce: true)).ResetAsync();
		}

		public UniTask ResetAsync(CancellationToken cancellationToken)
		{
			return ((IAsyncResetHandler)new AsyncTriggerHandler<AsyncUnit>(this, cancellationToken, callOnce: true)).ResetAsync();
		}
	}
}
