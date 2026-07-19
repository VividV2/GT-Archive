using System;
using System.Threading.Tasks;
using System;
using System.Threading.Tasks;
using System;
using System.Threading.Tasks;

namespace Modio.Customizations
{
	internal interface ISocketConnection
	{
		bool Connected();

		Task<Error> SendData(WssMessages message);

		Task<Error> SetupConnection(string url, Action<WssMessages> onReceiveMessage, Action onDisconnect);

		Task CloseConnection();
	}
}
namespace Modio.Customizations
{
	public interface IOculusCredentialProvider
	{
		Task<(Error, string)> GetOculusUserId();

		Task<string> GetOculusAccessToken();

		Task<string> GetOculusUserProof();

		string GetOculusDevice();
	}
}
