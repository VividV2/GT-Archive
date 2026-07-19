using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnCancelHandler
	{
		UniTask<UnityEngine.EventSystems.BaseEventData> OnCancelAsync();
	}
}
