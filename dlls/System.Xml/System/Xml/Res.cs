using System.Xml.Schema;
using System.Xml.Schema;

namespace System.Xml
{
	internal interface IValidationEventHandling
	{
		object EventHandler { get; }

		void SendEvent(Exception exception, XmlSeverityType severity);
	}
}
namespace System.Xml
{
}
