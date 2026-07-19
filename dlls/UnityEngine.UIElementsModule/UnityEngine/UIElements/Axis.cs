using System;

namespace UnityEngine.UIElements
{
	public enum Pivot
	{
		Center,
		TopLeft,
		TopCenter,
		TopRight,
		LeftCenter,
		RightCenter,
		BottomLeft,
		BottomCenter,
		BottomRight
	}
}
namespace UnityEngine.UIElements
{
	internal enum Axis
	{
		X,
		Y,
		Z
	}
}
namespace UnityEngine.UIElements
{
	[System.Obsolete("IUxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public interface IUxmlFactory : IBaseUxmlFactory
	{
		VisualElement Create(IUxmlAttributes bag, CreationContext cc);
	}
}
