using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
}
namespace PlayFab.ClientModels
{
	[Serializable]
	public class GetPlayFabIDsFromGameCenterIDsResult : PlayFabResultCommon
	{
		public List<GameCenterPlayFabIdPair> Data;
	}
}
