using System;

namespace UnityEngine.UIElements
{
	public enum CollectionVirtualizationMethod
	{
		FixedHeight,
		DynamicHeight
	}
}
namespace UnityEngine.UIElements
{
	[Serializable]
	[HelpURL("UIE-tss")]
	public class ThemeStyleSheet : StyleSheet
	{
		internal override void OnEnable()
		{
			base.isDefaultStyleSheet = true;
			base.OnEnable();
		}
	}
}
namespace UnityEngine.UIElements
{
	internal struct TextNativeSettings
	{
		public string text;

		public Font font;

		public int size;

		public float scaling;

		public FontStyle style;

		public Color color;

		public TextAnchor anchor;

		public bool wordWrap;

		public float wordWrapWidth;

		public bool richText;
	}
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements
{
}
