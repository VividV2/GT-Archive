using System.Xml.Serialization;

namespace System.Xml.Schema;

/// <summary>Indicator of how the attribute is used.</summary>
public enum XmlSchemaUse
{
	[XmlIgnore]
	None,
	[XmlEnum("optional")]
	Optional,
	[XmlEnum("prohibited")]
	Prohibited,
	[XmlEnum("required")]
	Required
}
