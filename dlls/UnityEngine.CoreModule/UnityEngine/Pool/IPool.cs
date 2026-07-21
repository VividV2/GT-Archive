using System;
using System;

namespace UnityEngine.Pool
{
	internal interface IPool
	{
		int CountInactive { get; }

		void Clear();
	}
}
namespace Unity.Jobs.LowLevel.Unsafe
{
	[Obsolete("Reflection data is now universal between job types. The parameter can be removed.", false)]
	public enum JobType
	{
		Single,
		ParallelFor
	}
}
