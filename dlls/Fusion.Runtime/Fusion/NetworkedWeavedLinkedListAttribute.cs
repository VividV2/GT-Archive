using System;
using System;
using System;

namespace Fusion
{
}
namespace Fusion
{
	[Flags]
	public enum NetworkObjectFlags
	{
		None = 0,
		MaskVersion = 0xFF,
		V1 = 1,
		Ignore = 0x10000,
		MasterClientObject = 0x20000,
		DestroyWhenStateAuthorityLeaves = 0x40000,
		AllowStateAuthorityOverride = 0x80000
	}
}
namespace Fusion
{
	[AttributeUsage(AttributeTargets.Property)]
	public class NetworkedWeavedLinkedListAttribute : Attribute
	{
		public int Capacity { get; }

		public int ElementWordCount { get; }

		public Type ElementReaderWriterType { get; }

		public NetworkedWeavedLinkedListAttribute(int capacity, int elementWordCount, Type elementReaderWriterType)
		{
			Capacity = capacity;
			ElementWordCount = elementWordCount;
			ElementReaderWriterType = elementReaderWriterType;
		}
	}
}
namespace Fusion
{
	public struct RpcInvokeData
	{
		public int Key;

		public int Sources;

		public int Targets;

		public RpcInvokeDelegate Delegate;

		public override string ToString()
		{
			return $"[{Key}, {Sources}, {Targets}, {Delegate}]";
		}
	}
}
namespace Fusion
{
}
namespace Fusion
{
}
