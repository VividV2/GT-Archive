namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnMoveHandler
	{
		UniTask<AxisEventData> OnMoveAsync();
	}
}
