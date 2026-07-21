using UnityEngine;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnCollisionExitHandler
	{
		UniTask<Collision> OnCollisionExitAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnMouseExitHandler
	{
		UniTask OnMouseExitAsync();
	}
}
