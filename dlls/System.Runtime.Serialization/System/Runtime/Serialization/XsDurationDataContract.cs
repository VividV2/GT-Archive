namespace System.Runtime.Serialization
{
	internal class XsDurationDataContract : TimeSpanDataContract
	{
		internal XsDurationDataContract()
			: base(DictionaryGlobals.TimeSpanLocalName, DictionaryGlobals.SchemaNamespace)
		{
		}
	}
}
namespace System.Runtime.Serialization
{
}
