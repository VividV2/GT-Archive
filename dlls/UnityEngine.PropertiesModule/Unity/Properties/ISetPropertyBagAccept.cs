using System.Collections.Generic;
using System.Collections.Generic;

namespace Unity.Properties
{
	public interface ISetPropertyBagAccept<TContainer>
	{
		void Accept(ISetPropertyBagVisitor visitor, ref TContainer container);
	}
}
namespace Unity.Properties
{
	public interface IListPropertyVisitor
	{
		void Visit<TContainer, TList, TElement>(Property<TContainer, TList> property, ref TContainer container, ref TList list) where TList : IList<TElement>;
	}
}
