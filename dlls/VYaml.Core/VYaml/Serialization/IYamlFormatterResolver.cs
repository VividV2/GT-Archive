namespace VYaml.Serialization
{
	public interface IYamlFormatterResolver
	{
		IYamlFormatter<T>? GetFormatter<T>();
	}
}
namespace VYaml.Serialization
{
}
