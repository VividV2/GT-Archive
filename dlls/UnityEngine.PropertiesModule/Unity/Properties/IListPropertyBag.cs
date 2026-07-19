using System.Collections.Generic;
using System.Collections.Generic;

namespace Unity.Properties;

public class ListPropertyBag<TElement> : IndexedCollectionPropertyBag<List<TElement>, TElement>
{
	protected override InstantiationKind InstantiationKind => InstantiationKind.PropertyBagOverride;

	protected override List<TElement> InstantiateWithCount(int count)
	{
		return new List<TElement>(count);
	}

	protected override List<TElement> Instantiate()
	{
		return new List<TElement>();
	}
}
namespace Unity.Properties
{
}
namespace Unity.Properties
{
	public interface IListPropertyBag<TList, TElement> : ICollectionPropertyBag<TList, TElement>, IPropertyBag<TList>, IPropertyBag, ICollectionPropertyBagAccept<TList>, IListPropertyBagAccept<TList>, IListPropertyAccept<TList>, IIndexedProperties<TList> where TList : IList<TElement>
	{
	}
}
