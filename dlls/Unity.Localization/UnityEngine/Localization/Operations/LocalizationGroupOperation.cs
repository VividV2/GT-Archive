using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.ResourceManagement.AsyncOperations;

namespace UnityEngine.Localization;

public interface IPreloadRequired
{
	AsyncOperationHandle PreloadOperation { get; }
}
