using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class QosServer : PlayFabBaseModel
	{
		public string Region;

		public string ServerUrl;
	}
}
namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class ServerDetails : PlayFabBaseModel
	{
		public string IPV4Address;

		public List<Port> Ports;

		public string Region;
	}
}
