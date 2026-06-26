using System.Diagnostics;
using System.Security;
using System.Security.Permissions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Runtime.CompilerServices;

/// <summary>Represents a builder for asynchronous methods that return a task.</summary>
[HostProtection(SecurityAction.LinkDemand, Synchronization = true, ExternalThreading = true)]
public struct AsyncTaskMethodBuilder
{
	private static readonly Task<VoidTaskResult> s_cachedCompleted = AsyncTaskMethodBuilder<VoidTaskResult>.s_defaultResultTask;

	private AsyncTaskMethodBuilder<VoidTaskResult> m_builder;

	/// <summary>Gets the task for this builder.</summary>
	/// <returns>The task for this builder.</returns>
	/// <exception cref="T:System.InvalidOperationException">The builder is not initialized.</exception>
	public Task Task => m_builder.Task;

	internal object ObjectIdForDebugger => Task;

	/// <summary>Creates an instance of the <see cref="T:System.Runtime.CompilerServices.AsyncTaskMethodBuilder" /> class.</summary>
	/// <returns>A new instance of the builder.</returns>
	public static AsyncTaskMethodBuilder Create()
	{
		return default(AsyncTaskMethodBuilder);
	}

	/// <summary>Begins running the builder with the associated state machine.</summary>
	/// <param name="stateMachine">The state machine instance, passed by reference.</param>
	/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stateMachine" /> is <see langword="null" />.</exception>
	[SecuritySafeCritical]
	[DebuggerStepThrough]
	public void Start<TStateMachine>(ref TStateMachine stateMachine) where TStateMachine : IAsyncStateMachine
	{
		if (stateMachine == null)
		{
			throw new ArgumentNullException("stateMachine");
		}
		ExecutionContextSwitcher ecsw = default(ExecutionContextSwitcher);
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			ExecutionContext.EstablishCopyOnWriteScope(ref ecsw);
			stateMachine.MoveNext();
		}
		finally
		{
			ecsw.Undo();
		}
	}

	/// <summary>Associates the builder with the specified state machine.</summary>
	/// <param name="stateMachine">The state machine instance to associate with the builder.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="stateMachine" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The state machine was previously set.</exception>
	public void SetStateMachine(IAsyncStateMachine stateMachine)
	{
		m_builder.SetStateMachine(stateMachine);
	}

	/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes.</summary>
	/// <param name="awaiter">The awaiter.</param>
	/// <param name="stateMachine">The state machine.</param>
	/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
	/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
	public void AwaitOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : INotifyCompletion where TStateMachine : IAsyncStateMachine
	{
		m_builder.AwaitOnCompleted(ref awaiter, ref stateMachine);
	}

	/// <summary>Schedules the state machine to proceed to the next action when the specified awaiter completes. This method can be called from partially trusted code.</summary>
	/// <param name="awaiter">The awaiter.</param>
	/// <param name="stateMachine">The state machine.</param>
	/// <typeparam name="TAwaiter">The type of the awaiter.</typeparam>
	/// <typeparam name="TStateMachine">The type of the state machine.</typeparam>
	public void AwaitUnsafeOnCompleted<TAwaiter, TStateMachine>(ref TAwaiter awaiter, ref TStateMachine stateMachine) where TAwaiter : ICriticalNotifyCompletion where TStateMachine : IAsyncStateMachine
	{
		m_builder.AwaitUnsafeOnCompleted(ref awaiter, ref stateMachine);
	}

	/// <summary>Marks the task as successfully completed.</summary>
	/// <exception cref="T:System.InvalidOperationException">The task has already completed.  
	///  -or-  
	///  The builder is not initialized.</exception>
	public void SetResult()
	{
		m_builder.SetResult(s_cachedCompleted);
	}

	/// <summary>Marks the task as failed and binds the specified exception to the task.</summary>
	/// <param name="exception">The exception to bind to the task.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///   <paramref name="exception" /> is <see langword="null" />.</exception>
	/// <exception cref="T:System.InvalidOperationException">The task has already completed.  
	///  -or-  
	///  The builder is not initialized.</exception>
	public void SetException(Exception exception)
	{
		m_builder.SetException(exception);
	}

	internal void SetNotificationForWaitCompletion(bool enabled)
	{
		m_builder.SetNotificationForWaitCompletion(enabled);
	}
}
