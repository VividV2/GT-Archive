namespace UnityEngine.ResourceManagement.ResourceProviders
{
	public enum ProviderBehaviourFlags
	{
		None,
		CanProvideWithFailedDependencies
	}
}
namespace UnityEngine.ResourceManagement.ResourceProviders
{
	internal interface ISceneProvider2 : ISceneProvider
	{
		AsyncOperationHandle<SceneInstance> ReleaseScene(ResourceManager resourceManager, AsyncOperationHandle<SceneInstance> sceneLoadHandle, UnloadSceneOptions unloadOptions);
	}
}
