using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class UpdateGroupRequest : PlayFabRequestCommon
	{
		public string AdminRoleId;

		public int? ExpectedProfileVersion;

		public EntityKey Group;

		public string GroupName;

		public string MemberRoleId;
	}
}
namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class CustomRegionSelectionRuleExpansion : PlayFabBaseModel
	{
		public List<OverrideUnsignedInt> MaxLatencyOverrides;

		public uint SecondsBetweenExpansions;
	}
}
