using System;

namespace UnityEngine.UIElements;

internal enum HierarchyChangeType
{
	AddedToParent,
	RemovedFromParent,
	ChildrenReordered,
	AttachedToPanel,
	DetachedFromPanel
}
namespace UnityEngine.UIElements
{
	[Serializable]
	internal struct GradientSettings
	{
		public GradientType gradientType;

		public AddressMode addressMode;

		public Vector2 radialFocus;

		public RectInt location;
	}
}
