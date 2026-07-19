namespace Fusion
{
	public interface ISceneLoadDone : IPublicFacingInterface
	{
		void SceneLoadDone(in SceneLoadDoneArgs sceneInfo);
	}
}
namespace Fusion
{
	public interface IInterestExit : IPublicFacingInterface
	{
		void InterestExit(PlayerRef player);
	}
}
