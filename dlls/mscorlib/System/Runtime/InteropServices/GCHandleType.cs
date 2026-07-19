using System.Threading;

namespace System;

/// <summary>Represents the status of an asynchronous operation.</summary>
public interface IAsyncResult
{
	bool IsCompleted { get; }

	WaitHandle AsyncWaitHandle { get; }

	object AsyncState { get; }

	bool CompletedSynchronously { get; }
}
