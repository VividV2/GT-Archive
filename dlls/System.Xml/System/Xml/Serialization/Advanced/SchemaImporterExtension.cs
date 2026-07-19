using System.Xml.XPath;
using System.Xml.XPath;

namespace System.Xml.Xsl.XsltOld;

internal class Sort(int sortkey, string xmllang, XmlDataType datatype, XmlSortOrder xmlorder, XmlCaseOrder xmlcaseorder)
{
	internal int select = sortkey;

	internal string lang = xmllang;

	internal XmlDataType dataType = datatype;

	internal XmlSortOrder order = xmlorder;

	internal XmlCaseOrder caseOrder = xmlcaseorder;
}
