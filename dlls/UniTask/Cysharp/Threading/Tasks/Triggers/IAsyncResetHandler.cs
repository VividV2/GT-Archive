namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnPreCullHandler
	{
		UniTask OnPreCullAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncResetHandler
	{
		UniTask ResetAsync();
	}
}
