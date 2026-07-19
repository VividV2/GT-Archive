using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnInitializePotentialDragHandler
	{
		UniTask<PointerEventData> OnInitializePotentialDragAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
}
