namespace System.Runtime.Serialization;

internal class ENTITIESDataContract : StringDataContract
{
	internal ENTITIESDataContract()
	{
		base..ctor(DictionaryGlobals.ENTITIESLocalName, DictionaryGlobals.SchemaNamespace);
	}
}
