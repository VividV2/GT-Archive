using Unity.Jobs.LowLevel.Unsafe;

namespace UnityEngine.Assertions.Must
{
}
namespace Unity.Jobs
{
	[JobProducerType(typeof(IJobForExtensions.ForJobStruct<>))]
	public interface IJobFor
	{
		void Execute(int index);
	}
}
namespace UnityEngine
{
}
