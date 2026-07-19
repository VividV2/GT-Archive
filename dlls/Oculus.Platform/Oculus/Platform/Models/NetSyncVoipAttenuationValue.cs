using System;

namespace Oculus.Platform.Models
{
	public class NetSyncVoipAttenuationValue
	{
		public readonly float Decibels;

		public readonly float Distance;

		public NetSyncVoipAttenuationValue(IntPtr o)
		{
			Decibels = CAPI.ovr_NetSyncVoipAttenuationValue_GetDecibels(o);
			Distance = CAPI.ovr_NetSyncVoipAttenuationValue_GetDistance(o);
		}
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
			base..ctor();
			DestinationApiName = CAPI.ovr_GroupPresenceLeaveIntent_GetDestinationApiName(o);
			LobbySessionId = CAPI.ovr_GroupPresenceLeaveIntent_GetLobbySessionId(o);
			MatchSessionId = CAPI.ovr_GroupPresenceLeaveIntent_GetMatchSessionId(o);
		}
	}
}
