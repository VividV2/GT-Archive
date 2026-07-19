using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class SetIntersectionRule : PlayFabBaseModel
	{
		public QueueRuleAttribute Attribute;

		public AttributeNotSpecifiedBehavior AttributeNotSpecifiedBehavior;

		public CustomSetIntersectionRuleExpansion CustomExpansion;

		public List<string> DefaultAttributeValue;

		public LinearSetIntersectionRuleExpansion LinearExpansion;

		public uint MinIntersectionSize;

		public string Name;

		public uint? SecondsUntilOptional;

		public double Weight;
	}
}
namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class TeamSizeBalanceRule : PlayFabBaseModel
	{
		public CustomTeamSizeBalanceRuleExpansion CustomExpansion;

		public uint Difference;

		public LinearTeamSizeBalanceRuleExpansion LinearExpansion;

		public string Name;

		public uint? SecondsUntilOptional;
	}
}
namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class EntityProfileFileMetadata : PlayFabBaseModel
	{
		public string Checksum;

		public string FileName;

		public DateTime LastModified;

		public int Size;
	}
}
