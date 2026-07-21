namespace UnityEngine.UIElements
{
	public enum TextOverflowPosition
	{
		End,
		Start,
		Middle
	}
}
namespace UnityEngine.UIElements
{
	public interface IStyleValue<T>
	{
		T value { get; set; }

		StyleKeyword keyword { get; set; }
	}
}
