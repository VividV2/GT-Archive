using System;
using PlayFab.SharedModels;
using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class GetMultiplayerServerLogsResponse : PlayFabResultCommon
	{
		public string LogDownloadUrl;
	}
}
namespace PlayFab.Json
{
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
	public class JsonProperty : Attribute
	{
		public string PropertyName;

		public NullValueHandling NullValueHandling;
	}
}
