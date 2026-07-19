namespace Newtonsoft.Json.Utilities
{
	internal delegate TResult MethodCall<T, TResult>(T target, params object?[] args);
}
namespace Newtonsoft.Json.Linq
{
	public enum CommentHandling
	{
		Ignore,
		Load
	}
}
namespace Newtonsoft.Json.Converters
{
}
