using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class CreateServerBackfillTicketResult : PlayFabResultCommon
	{
		public string TicketId;
	}
}
namespace PlayFab.CloudScriptModels
{
	[Serializable]
	public class PushNotificationRegistrationModel : PlayFabBaseModel
	{
		public string NotificationEndpointARN;

		public PushNotificationPlatform? Platform;
	}
}
