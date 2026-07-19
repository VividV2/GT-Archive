using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class RefreshPSNAuthTokenRequest : PlayFabRequestCommon
	{
		public string AuthCode;

		public int? IssuerId;

		public string RedirectUri;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class PlayerStatisticVersion : PlayFabBaseModel
	{
		public DateTime ActivationTime;

		public DateTime? DeactivationTime;

		public DateTime? ScheduledActivationTime;

		public DateTime? ScheduledDeactivationTime;

		public string StatisticName;

		public uint Version;
	}
}
