using Unity.Properties.Internal;

namespace Unity.Properties;

public readonly struct VisitContext<TContainer, TValue>
{
	private readonly ReadOnlyAdapterCollection.Enumerator m_Enumerator;

	private readonly PropertyVisitor m_Visitor;

	public Property<TContainer, TValue> Property { get; }

	internal static VisitContext<TContainer, TValue> FromProperty(PropertyVisitor visitor, ReadOnlyAdapterCollection.Enumerator enumerator, Property<TContainer, TValue> property)
	{
		return new VisitContext<TContainer, TValue>(visitor, enumerator, property);
	}

	private VisitContext(PropertyVisitor visitor, ReadOnlyAdapterCollection.Enumerator enumerator, Property<TContainer, TValue> property)
	{
		m_Visitor = visitor;
		m_Enumerator = enumerator;
		Property = property;
	}

	public void ContinueVisitation(ref TContainer container, ref TValue value)
	{
		m_Visitor.ContinueVisitation(Property, m_Enumerator, ref container, ref value);
	}

	public void ContinueVisitationWithoutAdapters(ref TContainer container, ref TValue value)
	{
		m_Visitor.ContinueVisitationWithoutAdapters(Property, m_Enumerator, ref container, ref value);
	}
}
