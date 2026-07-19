using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum EBeginAuthSessionResult
	{
		k_EBeginAuthSessionResultOK,
		k_EBeginAuthSessionResultInvalidTicket,
		k_EBeginAuthSessionResultDuplicateRequest,
		k_EBeginAuthSessionResultInvalidVersion,
		k_EBeginAuthSessionResultGameMismatch,
		k_EBeginAuthSessionResultExpiredTicket
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1202)]
	public struct P2PSessionRequest_t
	{
		public const int k_iCallback = 1202;

		public CSteamID m_steamIDRemote;
	}
}
