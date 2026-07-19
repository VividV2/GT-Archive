namespace System.Data;

/// <summary>Specifies how a <see cref="T:System.Data.DataColumn" /> is mapped.</summary>
public enum MappingType
{
	/// <summary>The column is mapped to an XML element.</summary>
	Element = 1,
	Attribute,
	SimpleContent,
	Hidden
}
