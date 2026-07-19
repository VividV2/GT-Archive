namespace System.Runtime.Serialization
{
	internal class DateDataContract : StringDataContract
	{
		internal DateDataContract()
			: base(DictionaryGlobals.dateLocalName, DictionaryGlobals.SchemaNamespace)
		{
		}
	}
}
namespace System.Runtime.Serialization
{
	internal class TokenDataContract : StringDataContract
	{
		internal TokenDataContract()
			: base(DictionaryGlobals.tokenLocalName, DictionaryGlobals.SchemaNamespace)
		{
		}
	}
}
