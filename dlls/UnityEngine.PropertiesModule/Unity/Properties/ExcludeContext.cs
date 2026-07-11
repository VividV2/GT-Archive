namespace Unity.Properties;

public readonly struct ExcludeContext<TContainer, TValue>
{
	private readonly PropertyVisitor m_Visitor;

	public Property<TContainer, TValue> Property { get; }

	internal static ExcludeContext<TContainer, TValue> FromProperty(PropertyVisitor visitor, Property<TContainer, TValue> property)
	{
		return new ExcludeContext<TContainer, TValue>(visitor, property);
	}

	private ExcludeContext(PropertyVisitor visitor, Property<TContainer, TValue> property)
	{
		m_Visitor = visitor;
		Property = property;
	}
}
