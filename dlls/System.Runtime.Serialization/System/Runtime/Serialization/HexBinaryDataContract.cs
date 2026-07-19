namespace System.Runtime.Serialization
{
	internal class HexBinaryDataContract : StringDataContract
	{
		internal HexBinaryDataContract()
			: base(DictionaryGlobals.hexBinaryLocalName, DictionaryGlobals.SchemaNamespace)
		{
		}
	}
}
namespace System.Runtime.Serialization
{
	internal class LanguageDataContract : StringDataContract
	{
		internal LanguageDataContract()
			: base(DictionaryGlobals.languageLocalName, DictionaryGlobals.SchemaNamespace)
		{
		}
	}
}
