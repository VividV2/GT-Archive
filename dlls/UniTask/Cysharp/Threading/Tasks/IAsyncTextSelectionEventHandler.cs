using System;

namespace Cysharp.Threading.Tasks
{
	public interface IAsyncTextSelectionEventHandler<T> : IDisposable
	{
		UniTask<T> OnTextSelectionAsync();
	}
}
namespace Cysharp.Threading.Tasks
{
}
