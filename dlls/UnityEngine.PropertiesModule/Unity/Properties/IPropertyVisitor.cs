using System.Collections.Generic;
using System.Collections.Generic;

namespace Unity.Properties
{
	public interface IPropertyVisitor
	{
		void Visit<TContainer, TValue>(Property<TContainer, TValue> property, ref TContainer container);
	}
}
namespace Unity.Properties
{
	public interface ICollectionPropertyBagVisitor
	{
		void Visit<TCollection, TElement>(ICollectionPropertyBag<TCollection, TElement> properties, ref TCollection container) where TCollection : ICollection<TElement>;
	}
}
