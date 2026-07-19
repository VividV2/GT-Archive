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
