using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class UnlinkKongregateAccountResult : PlayFabResultCommon
	{
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class UnlinkCustomIDRequest : PlayFabRequestCommon
	{
		public string CustomId;
	}
}
namespace PlayFab.ClientModels
{
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class UnlockContainerInstanceRequest : PlayFabRequestCommon
	{
		public string CatalogVersion;

		public string CharacterId;

		public string ContainerItemInstanceId;

		public string KeyItemInstanceId;
	}
}
