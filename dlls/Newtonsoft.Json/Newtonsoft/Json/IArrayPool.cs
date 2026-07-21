namespace Newtonsoft.Json
{
	public interface IArrayPool<T>
	{
		T[] Rent(int minimumLength);

		void Return(T[]? array);
	}
}
namespace Newtonsoft.Json
{
	internal enum JsonContainerType
	{
		None,
		Object,
		Array,
		Constructor
	}
}
