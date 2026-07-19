namespace Newtonsoft.Json.Serialization
{
}
namespace Newtonsoft.Json.Utilities
{
	internal delegate TResult MethodCall<T, TResult>(T target, params object?[] args);
}
