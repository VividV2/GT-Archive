using System.ComponentModel;
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
namespace System.Xml.Xsl.Runtime
{
	[System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
	public enum SetIteratorResult
	{
		NoMoreNodes,
		InitRightIterator,
		NeedLeftNode,
		NeedRightNode,
		HaveCurrentNode
	}
}
namespace System.Xml.Xsl.Runtime
{
}
