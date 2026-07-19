using System.Xml.XPath;

namespace System.Xml
{
}
namespace MS.Internal.Xml.XPath
{
	internal abstract class AstNode
	{
		public enum AstType
		{
			Axis,
			Operator,
			Filter,
			ConstantOperand,
			Function,
			Group,
			Root,
			Variable,
			Error
		}

		public abstract AstType Type { get; }

		public abstract XPathResultType ReturnType { get; }
	}
}
namespace System.Xml.Schema
{
}
