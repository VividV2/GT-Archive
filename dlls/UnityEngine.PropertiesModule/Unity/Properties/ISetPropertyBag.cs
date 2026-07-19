using System.Collections.Generic;

namespace Unity.Properties;

public interface IExcludeContravariantPropertyAdapter<in TValue> : IPropertyVisitorAdapter
{
	bool IsExcluded<TContainer>(in ExcludeContext<TContainer> context, ref TContainer container, TValue value);
}
namespace Unity.Properties
{
	public interface ISetPropertyBag<TSet, TElement> : ICollectionPropertyBag<TSet, TElement>, IPropertyBag<TSet>, IPropertyBag, ICollectionPropertyBagAccept<TSet>, ISetPropertyBagAccept<TSet>, ISetPropertyAccept<TSet>, IKeyedProperties<TSet, object> where TSet : ISet<TElement>
	{
	}
}
