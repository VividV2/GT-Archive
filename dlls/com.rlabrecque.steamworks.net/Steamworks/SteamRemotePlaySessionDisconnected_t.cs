namespace Steamworks
{
	public enum ESteamPartyBeaconLocationType
	{
		k_ESteamPartyBeaconLocationType_Invalid,
		k_ESteamPartyBeaconLocationType_ChatGroup,
		k_ESteamPartyBeaconLocationType_Max
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4012)]
	public struct MusicPlayerSelectsQueueEntry_t
	{
		public const int k_iCallback = 4012;

		public int nID;
	}
}
