namespace Steamworks
{
	public enum ESteamIPv6ConnectivityState
	{
		k_ESteamIPv6ConnectivityState_Unknown,
		k_ESteamIPv6ConnectivityState_Good,
		k_ESteamIPv6ConnectivityState_Bad
	}
}
namespace Steamworks
{
	public enum ESteamAPICallFailure
	{
		k_ESteamAPICallFailureNone = -1,
		k_ESteamAPICallFailureSteamGone,
		k_ESteamAPICallFailureNetworkFailure,
		k_ESteamAPICallFailureInvalidHandle,
		k_ESteamAPICallFailureMismatchedCallback
	}
}
