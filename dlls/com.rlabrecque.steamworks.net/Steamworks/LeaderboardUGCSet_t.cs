using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1111)]
	public struct LeaderboardUGCSet_t
	{
		public const int k_iCallback = 1111;

		public EResult m_eResult;

		public SteamLeaderboard_t m_hSteamLeaderboard;
	}
}
namespace Steamworks
{
	public enum ESteamInputGlyphStyle
	{
		ESteamInputGlyphStyle_Knockout = 0,
		ESteamInputGlyphStyle_Light = 1,
		ESteamInputGlyphStyle_Dark = 2,
		ESteamInputGlyphStyle_NeutralColorABXY = 0x10,
		ESteamInputGlyphStyle_SolidABXY = 0x20
	}
}
