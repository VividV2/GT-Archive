using System.Xml.XPath;
using System.Xml.XPath;
using System.Xml.XPath;

namespace System.Xml.Xsl.XsltOld
{
	internal class EndEvent : Event
	{
		private XPathNodeType nodeType;

		internal EndEvent(XPathNodeType nodeType)
		{
			this.nodeType = nodeType;
		}

		public override bool Output(Processor processor, ActionFrame frame)
		{
			return processor.EndEvent(nodeType);
		}
	}
}
namespace MS.Internal.Xml.XPath
{
	internal sealed class XPathSelfQuery : BaseAxisQuery
	{
		public XPathSelfQuery(Query qyInput, string Name, string Prefix, XPathNodeType Type)
			: base(qyInput, Name, Prefix, Type)
		{
		}

		private XPathSelfQuery(XPathSelfQuery other)
			: base(other)
		{
		}

		public override XPathNavigator Advance()
		{
			while ((currentNode = qyInput.Advance()) != null)
			{
				if (matches(currentNode))
				{
					position = 1;
					return currentNode;
				}
			}
			return null;
		}

		public override XPathNodeIterator Clone()
		{
			return new XPathSelfQuery(this);
		}
	}
}
