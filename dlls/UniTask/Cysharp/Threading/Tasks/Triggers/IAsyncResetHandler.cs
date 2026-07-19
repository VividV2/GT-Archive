using UnityEngine.EventSystems;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncResetHandler
	{
		UniTask ResetAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnMoveHandler
	{
		UniTask<AxisEventData> OnMoveAsync();
	}
}
