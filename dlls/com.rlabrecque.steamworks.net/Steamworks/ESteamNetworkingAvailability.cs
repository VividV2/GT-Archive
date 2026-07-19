using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(5211)]
public struct RequestPlayersForGameProgressCallback_t
{
	public const int k_iCallback = 5211;

	public EResult m_eResult;

	public ulong m_ullSearchID;
}
namespace Steamworks
{
	public enum ESteamNetworkingAvailability
	{
		k_ESteamNetworkingAvailability_CannotTry = -102,
		k_ESteamNetworkingAvailability_Failed = -101,
		k_ESteamNetworkingAvailability_Previously = -100,
		k_ESteamNetworkingAvailability_Retrying = -10,
		k_ESteamNetworkingAvailability_NeverTried = 1,
		k_ESteamNetworkingAvailability_Waiting = 2,
		k_ESteamNetworkingAvailability_Attempting = 3,
		k_ESteamNetworkingAvailability_Current = 100,
		k_ESteamNetworkingAvailability_Unknown = 0,
		k_ESteamNetworkingAvailability__Force32bit = int.MaxValue
	}
}
