namespace Unity.Properties
{
	public interface IExcludePropertyAdapter : IPropertyVisitorAdapter
	{
		bool IsExcluded<TContainer, TValue>(in ExcludeContext<TContainer, TValue> context, ref TContainer container, ref TValue value);
	}
}
namespace Unity.Properties
{
	public interface IVisitPrimitivesPropertyAdapter : IVisitPropertyAdapter<sbyte>, IPropertyVisitorAdapter, IVisitPropertyAdapter<short>, IVisitPropertyAdapter<int>, IVisitPropertyAdapter<long>, IVisitPropertyAdapter<byte>, IVisitPropertyAdapter<ushort>, IVisitPropertyAdapter<uint>, IVisitPropertyAdapter<ulong>, IVisitPropertyAdapter<float>, IVisitPropertyAdapter<double>, IVisitPropertyAdapter<bool>, IVisitPropertyAdapter<char>
	{
	}
}
