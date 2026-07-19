namespace System.Xml.Xsl
{
	[Flags]
	internal enum XmlNodeKindFlags
	{
		None = 0,
		Document = 1,
		Element = 2,
		Attribute = 4,
		Text = 8,
		Comment = 0x10,
		PI = 0x20,
		Namespace = 0x40,
		Content = 0x3A,
		Any = 0x7F
	}
}
namespace System.Xml.Serialization
{
	/// <summary>Delegate used by the <see cref="T:System.Xml.Serialization.XmlSerializer" /> class for deserialization of types from SOAP-encoded, non-root XML data. </summary>
	/// <returns>The object returned by the callback.</returns>
	public delegate object XmlSerializationReadCallback();
}
