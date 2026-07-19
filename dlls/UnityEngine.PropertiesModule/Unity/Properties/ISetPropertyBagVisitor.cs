using System.Collections.Generic;

namespace Unity.Properties
{
}
namespace Unity.Properties.Internal
{
}
namespace Unity.Properties.Internal
{
}
namespace Unity.Properties
{
	public interface ISetPropertyBagVisitor
	{
		void Visit<TSet, TValue>(ISetPropertyBag<TSet, TValue> properties, ref TSet container) where TSet : ISet<TValue>;
	}
}
namespace Unity.Properties
{
	public interface IVisitPropertyAdapter<TContainer, TValue> : IPropertyVisitorAdapter
	{
		void Visit(in VisitContext<TContainer, TValue> context, ref TContainer container, ref TValue value);
	}
}
