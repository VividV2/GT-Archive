using UnityEngine.EventSystems;
using UnityEngine.EventSystems;
using UnityEngine.EventSystems;

namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnPostRenderHandler
	{
		UniTask OnPostRenderAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnDisableHandler
	{
		UniTask OnDisableAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnMoveHandler
	{
		UniTask<AxisEventData> OnMoveAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
}
