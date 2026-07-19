using System;
using System.Collections.Generic;
using PlayFab.SharedModels;
using System;
using System.Collections.Generic;
using PlayFab.SharedModels;

namespace PlayFab.ProfilesModels
{
	[Serializable]
	public class GetEntityProfilesResponse : PlayFabResultCommon
	{
		public List<EntityProfileBody> Profiles;
	}
}
namespace PlayFab.InsightsModels
{
	[Serializable]
	public class InsightsPerformanceLevel : PlayFabBaseModel
	{
		public int ActiveEventExports;

		public int CacheSizeMB;

		public int Concurrency;

		public double CreditsPerMinute;

		public int EventsPerSecond;

		public int Level;

		public int MaxMemoryPerQueryMB;

		public int VirtualCpuCores;
	}
}
