using System;

namespace Cysharp.Threading.Tasks.Internal;

internal class StateTuple<T1> : IDisposable
{
	public T1 Item1;

	public void Deconstruct(out T1 item1)
	{
		item1 = Item1;
	}

	public void Dispose()
	{
		StatePool<T1>.Return(this);
	}
}
