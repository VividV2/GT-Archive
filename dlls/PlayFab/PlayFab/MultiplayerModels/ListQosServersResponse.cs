using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class ListGroupBlocksRequest : PlayFabRequestCommon
	{
		public EntityKey Group;
	}
}
namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class ListQosServersResponse : PlayFabResultCommon
	{
		public int PageSize;

		public List<QosServer> QosServers;

		public string SkipToken;
	}
}
