using System;
using Unity.Jobs.LowLevel.Unsafe;
using System;

namespace JetBrains.Annotations
{
	[Flags]
	public enum ImplicitUseKindFlags
	{
		Default = 7,
		Access = 1,
		Assign = 2,
		InstantiatedWithFixedConstructorSignature = 4,
		InstantiatedNoFixedConstructorSignature = 8
	}
}
namespace UnityEngine
{
}
namespace UnityEngine
{
}
namespace Unity.Jobs
{
	[Unity.Jobs.LowLevel.Unsafe.JobProducerType(typeof(IJobForExtensions.ForJobStruct<>))]
	public interface IJobFor
	{
		void Execute(int index);
	}
}
