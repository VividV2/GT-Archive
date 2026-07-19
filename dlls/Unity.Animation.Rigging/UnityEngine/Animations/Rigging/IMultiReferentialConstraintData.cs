namespace UnityEngine.Animations.Rigging;

public struct CacheIndex
{
	internal int idx;
}
namespace UnityEngine.Animations.Rigging
{
	public interface IMultiReferentialConstraintData
	{
		int driverValue { get; }

		string driverIntProperty { get; }

		Transform[] sourceObjects { get; }
	}
}
namespace UnityEngine.Animations.Rigging
{
}
