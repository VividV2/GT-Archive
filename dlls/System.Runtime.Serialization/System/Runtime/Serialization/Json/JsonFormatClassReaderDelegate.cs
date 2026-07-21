using System.Xml;

namespace System.Runtime.Serialization.Json
{
	internal delegate object JsonFormatClassReaderDelegate(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContextComplexJson context, XmlDictionaryString emptyDictionaryString, XmlDictionaryString[] memberNames);
}
namespace System.Runtime.Serialization
{
	internal delegate object XmlFormatClassReaderDelegate(XmlReaderDelegator xmlReader, XmlObjectSerializerReadContext context, XmlDictionaryString[] memberNames, XmlDictionaryString[] memberNamespaces);
}
namespace System.Runtime.Serialization
{
}
