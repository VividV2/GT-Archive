namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnPointerExitHandler
	{
		UniTask<PointerEventData> OnPointerExitAsync();
	}
}
namespace Cysharp.Threading.Tasks
{
}
