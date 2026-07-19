using System;
using System;

namespace Oculus.Platform.Models
{
	public class NetSyncSession(IntPtr o)
	{
		public readonly long ConnectionId = CAPI.ovr_NetSyncSession_GetConnectionId(o);

		public readonly bool Muted = CAPI.ovr_NetSyncSession_GetMuted(o);

		public readonly ulong SessionId = CAPI.ovr_NetSyncSession_GetSessionId(o);

		public readonly ulong UserId = CAPI.ovr_NetSyncSession_GetUserId(o);

		public readonly string VoipGroup = CAPI.ovr_NetSyncSession_GetVoipGroup(o);
	}
}
namespace Oculus.Platform.Models
{
}
