using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(5201)]
	public struct SearchForGameProgressCallback_t
	{
		public const int k_iCallback = 5201;

		public ulong m_ullSearchID;

		public EResult m_eResult;

		public CSteamID m_lobbyID;

		public CSteamID m_steamIDEndedSearch;

		public int m_nSecondsRemainingEstimate;

		public int m_cPlayersSearching;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1107)]
	public struct NumberOfCurrentPlayers_t
	{
		public const int k_iCallback = 1107;

		public byte m_bSuccess;

		public int m_cPlayers;
	}
}
