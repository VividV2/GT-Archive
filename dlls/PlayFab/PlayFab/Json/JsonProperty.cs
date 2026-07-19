using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.EventsModels
{
	[Serializable]
	public class WriteEventsRequest : PlayFabRequestCommon
	{
		public List<EventContents> Events;
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
