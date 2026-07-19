using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.GroupsModels
{
	[Serializable]
	public class RemoveMembersRequest : PlayFabRequestCommon
	{
		public EntityKey Group;

		public List<EntityKey> Members;

		public string RoleId;
	}
}
namespace PlayFab.MultiplayerModels
{
	public enum ContainerFlavor
	{
		ManagedWindowsServerCore,
		CustomLinux,
		ManagedWindowsServerCorePreview,
		Invalid
	}
}
