using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class LoginWithGoogleAccountRequest : PlayFabRequestCommon
	{
		public bool? CreateAccount;

		public string EncryptedRequest;

		public GetPlayerCombinedInfoRequestParams InfoRequestParameters;

		public string PlayerSecret;

		public string ServerAuthCode;

		public string TitleId;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class ItemInstance : PlayFabBaseModel
	{
		public string Annotation;

		public List<string> BundleContents;

		public string BundleParent;

		public string CatalogVersion;

		public Dictionary<string, string> CustomData;

		public string DisplayName;

		public DateTime? Expiration;

		public string ItemClass;

		public string ItemId;

		public string ItemInstanceId;

		public DateTime? PurchaseDate;

		public int? RemainingUses;

		public string UnitCurrency;

		public uint UnitPrice;

		public int? UsesIncrementedBy;

		public ItemInstance()
		{
			base..ctor();
		}
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayerCombinedInfoResultPayload : PlayFabBaseModel
	{
		public UserAccountInfo AccountInfo;

		public List<CharacterInventory> CharacterInventories;

		public List<CharacterResult> CharacterList;

		public PlayerProfileModel PlayerProfile;

		public List<StatisticValue> PlayerStatistics;

		public Dictionary<string, string> TitleData;

		public Dictionary<string, UserDataRecord> UserData;

		public uint UserDataVersion;

		public List<ItemInstance> UserInventory;

		public Dictionary<string, UserDataRecord> UserReadOnlyData;

		public uint UserReadOnlyDataVersion;

		public Dictionary<string, int> UserVirtualCurrency;

		public Dictionary<string, VirtualCurrencyRechargeTime> UserVirtualCurrencyRechargeTimes;
	}
}
