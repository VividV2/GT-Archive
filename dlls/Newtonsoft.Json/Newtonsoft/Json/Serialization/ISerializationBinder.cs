using System;

namespace Newtonsoft.Json.Serialization
{
	public interface ISerializationBinder
	{
		Type BindToType(string? assemblyName, string typeName);

		void BindToName(Type serializedType, out string? assemblyName, out string? typeName);
	}
}
namespace Newtonsoft.Json.Bson
{
}
namespace Newtonsoft.Json.Converters
{
	internal interface IXmlDocumentType : IXmlNode
	{
		string Name { get; }

		string? System { get; }

		string? Public { get; }

		string? InternalSubset { get; }
	}
}
