namespace UnityEngine.ResourceManagement.AsyncOperations
{
}
namespace UnityEngine.ResourceManagement.ResourceLocations
{
	public interface ILocationSizeData
	{
		long ComputeSize(IResourceLocation location, ResourceManager resourceManager);
	}
}
