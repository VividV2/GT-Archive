using System;
using PlayFab.SharedModels;

namespace PlayFab.MultiplayerModels
{
	public enum CancellationReason
	{
		Requested,
		Internal,
		Timeout
	}
}
namespace PlayFab.MultiplayerModels
{
	[Serializable]
	public class StatisticsVisibilityToPlayers : PlayFabBaseModel
	{
		public bool ShowNumberOfPlayersMatching;

		public bool ShowTimeToMatch;
	}
}
