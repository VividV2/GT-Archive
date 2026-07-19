using System.Xml.Xsl.Qil;
using System.Xml.Xsl.Qil;

namespace System.Xml.Xsl.XPath
{
	internal interface IFocus
	{
		QilNode GetCurrent();

		QilNode GetPosition();

		QilNode GetLast();
	}
}
namespace System.Xml.Serialization
{
	internal enum TypeKind
	{
		Root,
		Primitive,
		Enum,
		Struct,
		Class,
		Array,
		Collection,
		Enumerable,
		Void,
		Node,
		Attribute,
		Serializable
	}
}
