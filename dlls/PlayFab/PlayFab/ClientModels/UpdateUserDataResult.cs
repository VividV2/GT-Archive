using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class WriteTitleEventRequest : PlayFabRequestCommon
	{
		public Dictionary<string, object> Body;

		public string EventName;

		public DateTime? Timestamp;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class UpdateUserDataResult : PlayFabResultCommon
	{
		public uint DataVersion;
	}
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class UserNintendoSwitchDeviceIdInfo : PlayFabBaseModel
	{
		public string NintendoSwitchDeviceId;

		public UserNintendoSwitchDeviceIdInfo()
		{
			base..ctor();
		}
	}
}
namespace PlayFab.ClientModels
{
}
