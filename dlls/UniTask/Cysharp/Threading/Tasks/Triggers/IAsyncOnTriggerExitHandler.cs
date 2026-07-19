using UnityEngine;
using UnityEngine;

namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnTriggerExitHandler
	{
		UniTask<Collider> OnTriggerExitAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
	public interface IAsyncOnValidateHandler
	{
		UniTask OnValidateAsync();
	}
}
namespace Cysharp.Threading.Tasks.Triggers
{
}
