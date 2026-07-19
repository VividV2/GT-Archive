namespace Cysharp.Threading.Tasks
{
	public interface ITaskPoolNode<T>
	{
		ref T NextNode { get; }
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
}
