namespace Unity.Properties
{
	public interface ICollectionPropertyBagAccept<TContainer>
	{
		void Accept(ICollectionPropertyBagVisitor visitor, ref TContainer container);
	}
}
namespace Unity.Properties
{
	public interface IPropertyAccept<TContainer>
	{
		void Accept(IPropertyVisitor visitor, ref TContainer container);
	}
}
namespace Unity.Properties
{
	public abstract class ConcreteTypeVisitor : IPropertyBagVisitor
	{
		protected abstract void VisitContainer<TContainer>(ref TContainer container);

		void IPropertyBagVisitor.Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container)
		{
			VisitContainer(ref container);
		}
	}
}
