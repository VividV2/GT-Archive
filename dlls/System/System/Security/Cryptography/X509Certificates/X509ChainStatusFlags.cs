namespace System.ComponentModel;

public abstract class ContainerFilterService
{
	protected ContainerFilterService()
	{
	}

	public virtual ComponentCollection FilterComponents(ComponentCollection components)
	{
		return components;
	}
}
