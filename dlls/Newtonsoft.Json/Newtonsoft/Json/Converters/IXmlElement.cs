using System;
using System.Diagnostics;
using System;
using System.Diagnostics;

namespace Newtonsoft.Json.Serialization
{
	public interface ITraceWriter
	{
		TraceLevel LevelFilter { get; }

		void Trace(TraceLevel level, string message, Exception? ex);
	}
}
namespace Newtonsoft.Json.Converters
{
	internal interface IXmlElement : IXmlNode
	{
		bool IsEmpty { get; }

		void SetAttributeNode(IXmlNode attribute);

		string? GetPrefixOfNamespace(string namespaceUri);
	}
}
namespace Newtonsoft.Json.Serialization
{
}
