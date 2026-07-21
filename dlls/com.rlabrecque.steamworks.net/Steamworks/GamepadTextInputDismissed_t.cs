using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(714)]
	public struct GamepadTextInputDismissed_t
	{
		public const int k_iCallback = 714;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bSubmitted;

		public uint m_unSubmittedText;

		public AppId_t m_unAppID;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1106)]
	public struct LeaderboardScoreUploaded_t
	{
		public const int k_iCallback = 1106;

		public byte m_bSuccess;

		public SteamLeaderboard_t m_hSteamLeaderboard;

		public int m_nScore;

		public byte m_bScoreChanged;

		public int m_nGlobalRankNew;

		public int m_nGlobalRankPrevious;
	}
}
