namespace System.Xml.Serialization;

internal class NameKey
{
	private string ns;

	private string name;

	internal NameKey(string name, string ns)
	{
		base..ctor();
		this.name = name;
		this.ns = ns;
	}

	public override bool Equals(object other)
	{
		if (!other is NameKey)
			return false;
		nameKey = (NameKey)other;
		if (string.op_Equality(name, nameKey.name))
			return string.op_Equality(ns, nameKey.ns);
		return false;
	}

	public override int GetHashCode()
	{
		return ns == null ? "<null>".GetHashCode() : ns.GetHashCode() ^ name != null ? name.GetHashCode() : 0;
	}
}
