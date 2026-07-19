namespace UnityEngine.UIElements;

public interface IBinding
{
	void PreUpdate();

	void Update();

	void Release();
}
namespace UnityEngine.UIElements.Layout
{
	internal enum LayoutJustify
	{
		FlexStart,
		Center,
		FlexEnd,
		SpaceBetween,
		SpaceAround,
		SpaceEvenly
	}
}
