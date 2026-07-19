using System;
using System.Net;
using PlayFab.SharedModels;
using System.Net;

namespace PlayFab.DataModels
{
}
namespace PlayFab.ExperimentationModels
{
	[Serializable]
	public class EmptyResponse : PlayFabResultCommon
	{
	}
}
namespace PlayFab.Public
{
	public interface IPlayFabLogger
	{
		IPAddress ip { get; set; }

		int port { get; set; }

		string url { get; set; }

		void OnEnable();

		void OnDisable();

		void OnDestroy();
	}
}
