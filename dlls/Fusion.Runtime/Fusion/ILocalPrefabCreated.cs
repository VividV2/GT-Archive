#define DEBUG
namespace Fusion;

public enum NetworkPrefabTableGetPrefabResult
{
	Success,
	InProgress,
	NotFound,
	LoadError
}
namespace Fusion
{
	public interface ILocalPrefabCreated : IPublicFacingInterface
	{
		void LocalPrefabCreated();
	}
}
namespace Fusion
{
}
