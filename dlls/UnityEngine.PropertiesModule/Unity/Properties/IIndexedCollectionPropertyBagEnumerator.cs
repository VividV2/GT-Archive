namespace Unity.Properties
{
	internal interface IIndexedCollectionPropertyBagEnumerator<TContainer>
	{
		int GetCount(ref TContainer container);

		IProperty<TContainer> GetSharedProperty();

		IndexedCollectionSharedPropertyState GetSharedPropertyState();

		void SetSharedPropertyState(IndexedCollectionSharedPropertyState state);
	}
}
namespace Unity.Properties
{
	public interface IProperty<TContainer> : IProperty, IPropertyAccept<TContainer>
	{
		object GetValue(ref TContainer container);

		void SetValue(ref TContainer container, object value);
	}
}
