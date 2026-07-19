namespace Unity.Properties
{
	public interface IListPropertyBagAccept<TContainer>
	{
		void Accept(IListPropertyBagVisitor visitor, ref TContainer container);
	}
}
namespace Unity.Properties
{
	public interface IPropertyBagVisitor
	{
		void Visit<TContainer>(IPropertyBag<TContainer> properties, ref TContainer container);
	}
}
