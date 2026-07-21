using System.Collections.Generic;

namespace Unity.Properties
{
	public interface IListPropertyAccept<TList>
	{
		void Accept<TContainer>(IListPropertyVisitor visitor, Property<TContainer, TList> property, ref TContainer container, ref TList list);
	}
}
namespace Unity.Properties
{
	public interface ICollectionPropertyBagVisitor
	{
		void Visit<TCollection, TElement>(ICollectionPropertyBag<TCollection, TElement> properties, ref TCollection container) where TCollection : ICollection<TElement>;
	}
}
