namespace System.Xml.Serialization;

internal enum Cmp
{
	LessThan,
	EqualTo,
	LessThanOrEqualTo,
	GreaterThan,
	NotEqualTo,
	GreaterThanOrEqualTo
}
namespace System.Xml.Schema
{
}
namespace System.Xml.Xsl.Runtime
{
	internal class XmlILQueryEventArgs : XsltMessageEncounteredEventArgs
	{
		private string message;

		public override string Message => message;

		public XmlILQueryEventArgs(string message)
		{
			this.message = message;
		}
	}
}
