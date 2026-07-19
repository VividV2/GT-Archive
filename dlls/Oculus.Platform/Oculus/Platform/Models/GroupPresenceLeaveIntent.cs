using System;
using System;

namespace Oculus.Platform.Models
{
	public class NetSyncVoipAttenuationValue(IntPtr o)
	{
		public readonly float Decibels = CAPI.ovr_NetSyncVoipAttenuationValue_GetDecibels(o);

		public readonly float Distance = CAPI.ovr_NetSyncVoipAttenuationValue_GetDistance(o);
	}
}
namespace Oculus.Platform.Models
{
	public class GroupPresenceLeaveIntent
	{
		public readonly string DestinationApiName;

		public readonly string LobbySessionId;

		public readonly string MatchSessionId;

		public GroupPresenceLeaveIntent(IntPtr o)
		{
			DestinationApiName = CAPI.ovr_GroupPresenceLeaveIntent_GetDestinationApiName(o);
			LobbySessionId = CAPI.ovr_GroupPresenceLeaveIntent_GetLobbySessionId(o);
			MatchSessionId = CAPI.ovr_GroupPresenceLeaveIntent_GetMatchSessionId(o);
		}
	}
}
