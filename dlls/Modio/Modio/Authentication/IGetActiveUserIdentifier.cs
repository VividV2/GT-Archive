using System.Threading.Tasks;
using System.Threading.Tasks;

namespace Modio.Authentication
{
	public interface IGetActiveUserIdentifier
	{
		Task<string> GetActiveUserIdentifier();
	}
}
namespace Modio.Customizations
{
	[System.Serializable]
	internal struct WssDeviceLoginResponse
	{
		public string code;

		public long date_expires;

		public string display_url;

		public string login_url;
	}
}
namespace Modio.Mods
{
}
