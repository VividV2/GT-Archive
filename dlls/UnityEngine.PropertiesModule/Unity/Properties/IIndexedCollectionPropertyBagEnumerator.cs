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
	public interface INamedProperties<TContainer>
	{
		bool TryGetProperty(ref TContainer container, string name, out IProperty<TContainer> property);
	}
}
