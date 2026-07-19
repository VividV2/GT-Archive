using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnCollisionStayHandler
	{
		UniTask<Collision> OnCollisionStayAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
}
