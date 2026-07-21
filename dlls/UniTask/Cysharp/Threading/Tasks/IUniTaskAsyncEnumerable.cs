using System.Threading;

namespace Cysharp.Threading.Tasks
{
}
namespace Cysharp.Threading.Tasks
{
	public interface IUniTaskAsyncEnumerable<out T>
	{
		IUniTaskAsyncEnumerator<T> GetAsyncEnumerator(CancellationToken cancellationToken = default(CancellationToken));
	}
}
namespace Cysharp.Threading.Tasks
{
}
