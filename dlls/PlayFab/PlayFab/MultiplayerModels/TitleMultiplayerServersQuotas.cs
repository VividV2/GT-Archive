using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class TitleMultiplayerServersQuotas : PlayFabBaseModel
	{
		public List<CoreCapacity> CoreCapacities;
	}
}
namespace PlayFab.InsightsModels
{
	[Serializable]
	public class InsightsGetPendingOperationsRequest : PlayFabRequestCommon
	{
		public string OperationType;
	}
}
