using System.Threading.Tasks;
using System.Threading.Tasks;

namespace Liv.Lck.Core
{
	public interface ILckCore
	{
		Task<Result<bool>> HasUserConfiguredStreaming();

		Task<Result<bool>> IsUserSubscribed();

		Task<Result<string>> StartLoginAttemptAsync();

		Task<Result<bool>> CheckLoginCompletedAsync();

		Task<Result<float>> GetRemainingBackoffTimeSeconds();
	}
}
namespace Liv.Lck.Core
{
	public struct LckInfo
	{
		public string Version;

		public int BuildNumber;
	}
}
namespace Liv.Lck.Core
{
}
