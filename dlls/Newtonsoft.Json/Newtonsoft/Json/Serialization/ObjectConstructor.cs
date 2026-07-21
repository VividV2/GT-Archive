namespace Newtonsoft.Json.Serialization
{
	public delegate object ObjectConstructor<T>(params object?[] args);
}
namespace Newtonsoft.Json.Serialization
{
	public delegate IEnumerable<KeyValuePair<object, object>>? ExtensionDataGetter(object o);
}
