using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class GetRemoteLoginEndpointResponse : PlayFabResultCommon
	{
		public string IPV4Address;

		public int Port;
	}
}
namespace PlayFab.GroupsModels
{
	[Serializable]
	public class ListGroupInvitationsResponse : PlayFabResultCommon
	{
		public List<GroupInvitation> Invitations;
	}
}
namespace PlayFab.MultiplayerModels
{
}
