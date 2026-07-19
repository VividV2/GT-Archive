namespace System.Xml.Serialization
{
	/// <summary>Represents the method that handles the <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> event of an <see cref="T:System.Xml.Serialization.XmlSerializer" />.</summary>
	/// <summary>Represents the method that handles the <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> event of an <see cref="T:System.Xml.Serialization.XmlSerializer" />.</summary>
	/// <param name="sender">The source of the event. </param>
	/// <param name="sender">The source of the event. </param>
	/// <param name="e">An <see cref="T:System.Xml.Serialization.XmlNodeEventArgs" /> that contains the event data. </param>
	/// <param name="e">An <see cref="T:System.Xml.Serialization.XmlNodeEventArgs" /> that contains the event data. </param>
	/// <summary>Represents the method that handles the <see cref="E:System.Xml.Serialization.XmlSerializer.UnknownNode" /> event of an <see cref="T:System.Xml.Serialization.XmlSerializer" />.</summary>
	/// <param name="sender">The source of the event. </param>
	/// <param name="e">An <see cref="T:System.Xml.Serialization.XmlNodeEventArgs" /> that contains the event data. </param>
	public delegate void XmlNodeEventHandler(object sender, XmlNodeEventArgs e);
}
namespace System.Xml
{
	/// <summary>Specifies the method used to serialize the <see cref="T:System.Xml.XmlWriter" /> output. </summary>
	/// <summary>Specifies the method used to serialize the <see cref="T:System.Xml.XmlWriter" /> output. </summary>
	/// <summary>Specifies the method used to serialize the <see cref="T:System.Xml.XmlWriter" /> output. </summary>
	public enum XmlOutputMethod
	{
		/// <summary>Serialize according to the XML 1.0 rules.</summary>
		/// <summary>Serialize according to the XML 1.0 rules.</summary>
		/// <summary>Serialize according to the XML 1.0 rules.</summary>
		Xml,
		/// <summary>Serialize according to the HTML rules specified by XSLT.</summary>
		/// <summary>Serialize according to the HTML rules specified by XSLT.</summary>
		/// <summary>Serialize according to the HTML rules specified by XSLT.</summary>
		Html,
		/// <summary>Serialize text blocks only.</summary>
		/// <summary>Serialize text blocks only.</summary>
		/// <summary>Serialize text blocks only.</summary>
		Text,
		/// <summary>Use the XSLT rules to choose between the <see cref="F:System.Xml.XmlOutputMethod.Xml" /> and <see cref="F:System.Xml.XmlOutputMethod.Html" /> output methods at runtime.</summary>
		/// <summary>Use the XSLT rules to choose between the <see cref="F:System.Xml.XmlOutputMethod.Xml" /> and <see cref="F:System.Xml.XmlOutputMethod.Html" /> output methods at runtime.</summary>
		/// <summary>Use the XSLT rules to choose between the <see cref="F:System.Xml.XmlOutputMethod.Xml" /> and <see cref="F:System.Xml.XmlOutputMethod.Html" /> output methods at runtime.</summary>
		AutoDetect
	}
}
