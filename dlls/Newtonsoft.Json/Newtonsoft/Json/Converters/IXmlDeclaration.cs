namespace Newtonsoft.Json.Serialization
{
	public interface IReferenceResolver
	{
		object ResolveReference(object context, string reference);

		string GetReference(object context, object value);

		bool IsReferenced(object context, object value);

		void AddReference(object context, string reference, object value);
	}
}
namespace Newtonsoft.Json.Converters
{
	internal interface IXmlDeclaration : IXmlNode
	{
		string? Version { get; }

		string? Encoding { get; set; }

		string? Standalone { get; set; }
	}
}
