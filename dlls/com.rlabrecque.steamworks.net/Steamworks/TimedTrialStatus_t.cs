using System.Runtime.InteropServices;

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
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1030)]
	public struct TimedTrialStatus_t
	{
		public const int k_iCallback = 1030;

		public AppId_t m_unAppID;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bIsOffline;

		public uint m_unSecondsAllowed;

		public uint m_unSecondsPlayed;
	}
}
