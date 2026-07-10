using System;
using System.Threading;
using UnityEngine.Events;

namespace Cysharp.Threading.Tasks;

public class AsyncUnityEventHandler : IUniTaskSource, IDisposable, IAsyncClickEventHandler
{
	private static Action<object> cancellationCallback = CancellationCallback;

	private readonly UnityAction action;

	private readonly UnityEvent unityEvent;

	private CancellationToken cancellationToken;

	private CancellationTokenRegistration registration;

	private bool isDisposed;

	private bool callOnce;

	private UniTaskCompletionSourceCore<AsyncUnit> core;

	public AsyncUnityEventHandler(UnityEvent unityEvent, CancellationToken cancellationToken, bool callOnce)
	{
		this.cancellationToken = cancellationToken;
		if (cancellationToken.IsCancellationRequested)
		{
			isDisposed = true;
			return;
		}
		action = Invoke;
		this.unityEvent = unityEvent;
		this.callOnce = callOnce;
		unityEvent.AddListener(action);
		if (cancellationToken.CanBeCanceled)
		{
			registration = cancellationToken.RegisterWithoutCaptureExecutionContext(cancellationCallback, this);
		}
	}

	public UniTask OnInvokeAsync()
	{
		core.Reset();
		if (isDisposed)
		{
			core.TrySetCanceled(cancellationToken);
		}
		return new UniTask(this, core.Version);
	}

	private void Invoke()
	{
		core.TrySetResult(AsyncUnit.Default);
	}

	private static void CancellationCallback(object state)
	{
		((AsyncUnityEventHandler)state).Dispose();
	}

	public void Dispose()
	{
		if (!isDisposed)
		{
			isDisposed = true;
			registration.Dispose();
			if (unityEvent != null)
			{
				unityEvent.RemoveListener(action);
			}
			core.TrySetCanceled(cancellationToken);
		}
	}

	UniTask IAsyncClickEventHandler.OnClickAsync()
	{
		return OnInvokeAsync();
	}

	void IUniTaskSource.GetResult(short token)
	{
		try
		{
			core.GetResult(token);
		}
		finally
		{
			if (callOnce)
			{
				Dispose();
			}
		}
	}

	UniTaskStatus IUniTaskSource.GetStatus(short token)
	{
		return core.GetStatus(token);
	}

	UniTaskStatus IUniTaskSource.UnsafeGetStatus()
	{
		return core.UnsafeGetStatus();
	}

	void IUniTaskSource.OnCompleted(Action<object> continuation, object state, short token)
	{
		core.OnCompleted(continuation, state, token);
	}
}
