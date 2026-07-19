namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnRenderObjectHandler
	{
		UniTask OnRenderObjectAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnPointerClickHandler
	{
		UniTask<PointerEventData> OnPointerClickAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnBeginDragHandler
	{
		UniTask<PointerEventData> OnBeginDragAsync();
	}
}
