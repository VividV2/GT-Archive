namespace System.Xml
{
	internal interface IDtdDefaultAttributeInfo : IDtdAttributeInfo
	{
		string DefaultValueExpanded { get; }

		object DefaultValueTyped { get; }

		int ValueLineNumber { get; }

		int ValueLinePosition { get; }
	}
}
namespace System.Xml.Xsl.XsltOld
{
}
