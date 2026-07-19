using System.Threading.Tasks;

namespace Modio.Monetization
{
	public interface IModioStorefrontService
	{
		Task<Error> OpenPlatformPurchaseFlow();
	}
}
namespace Modio.Mods
{
}
