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
}
