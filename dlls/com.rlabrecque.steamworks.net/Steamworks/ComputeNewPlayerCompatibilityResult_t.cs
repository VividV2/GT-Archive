using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(736)]
	public struct AppResumingFromSuspend_t
	{
		public const int k_iCallback = 736;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(211)]
	public struct ComputeNewPlayerCompatibilityResult_t
	{
		public const int k_iCallback = 211;

		public EResult m_eResult;

		public int m_cPlayersThatDontLikeCandidate;

		public int m_cPlayersThatCandidateDoesntLike;

		public int m_cClanPlayersThatDontLikeCandidate;

		public CSteamID m_SteamIDCandidate;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4700)]
	public struct SteamInventoryResultReady_t
	{
		public const int k_iCallback = 4700;

		public SteamInventoryResult_t m_handle;

		public EResult m_result;
	}
}
namespace Steamworks
{
}
