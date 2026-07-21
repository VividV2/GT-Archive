namespace PerformanceSystems
{
	public interface ITimeSlice
	{
		void SliceUpdate();

		void SliceUpdateAlways(float deltaTime);

		void SliceUpdate(float deltaTime);
	}
}
namespace Viveport.Internal
{
	internal enum ELeaderboardUploadScoreMethod
	{
		k_ELeaderboardUploadScoreMethodNone,
		k_ELeaderboardUploadScoreMethodKeepBest,
		k_ELeaderboardUploadScoreMethodForceUpdate
	}
}
namespace LitJson
{
}
