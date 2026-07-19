using System;
using PlayFab.SharedModels;

namespace PlayFab.CloudScriptModels
{
	[Serializable]
	public class ContactEmailInfoModel : PlayFabBaseModel
	{
		public string EmailAddress;

		public string Name;

		public EmailVerificationStatus? VerificationStatus;
	}
}
namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class EntityLineage : PlayFabBaseModel
	{
		public string CharacterId;

		public string GroupId;

		public string MasterPlayerAccountId;

		public string NamespaceId;

		public string TitleId;

		public string TitlePlayerAccountId;
	}
}
