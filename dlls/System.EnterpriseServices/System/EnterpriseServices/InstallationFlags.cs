namespace System.EnterpriseServices;

[AttributeUsage(AttributeTargets.Assembly)]
[ComVisible(false)]
public sealed class ApplicationIDAttribute : Attribute, IConfigurationAttribute
{
	private Guid guid;

	public Guid Value
	{
		get
		{
			return guid;
		}
	}

	public ApplicationIDAttribute(string guid)
	{
		base..ctor();
		this.guid = new Guid(guid);
	}

	bool IConfigurationAttribute.AfterSaveChanges(Hashtable info)
	{
		return false;
	}

	bool IConfigurationAttribute.Apply(Hashtable cache)
	{
		return false;
	}

	bool IConfigurationAttribute.IsValidTarget(string s)
	{
		return s == "Application";
	}
}
