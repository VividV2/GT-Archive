using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels;

[Serializable]
public class GetContainerRegistryCredentialsResponse : PlayFabResultCommon
{
	public string DnsName;

	public string Password;

	public string Username;
}
namespace PlayFab.EventsModels
{
	[Serializable]
	public class EventContents : PlayFabBaseModel
	{
		public EntityKey Entity;

		public string EventNamespace;

		public string Name;

		public string OriginalId;

		public DateTime? OriginalTimestamp;

		public object Payload;

		public string PayloadJSON;
	}
}
