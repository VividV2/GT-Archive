using UnityEngine.EventSystems;
using UnityEngine.EventSystems;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnBeforeTransformParentChangedHandler
	{
		UniTask OnBeforeTransformParentChangedAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnUpdateSelectedHandler
	{
		UniTask<BaseEventData> OnUpdateSelectedAsync();
	}
}
namespace Cysharp.Threading.Tasks
{
	public interface IUniTaskAsyncEnumerator<out T> : IUniTaskAsyncDisposable
	{
		T Current { get; }

		UniTask<bool> MoveNextAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
}
