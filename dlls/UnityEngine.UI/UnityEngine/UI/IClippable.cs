using System;
using System.ComponentModel;
using System;
using System.ComponentModel;

namespace UnityEngine.UI;

[EditorBrowsable(EditorBrowsableState.Never)]
[Obsolete("Not supported anymore.", true)]
public interface IMask
{
	RectTransform rectTransform { get; }

	bool Enabled();
}
namespace UnityEngine.UI
{
}
namespace UnityEngine.UI
{
	public interface IClippable
	{
		GameObject gameObject { get; }

		RectTransform rectTransform { get; }

		void RecalculateClipping();

		void Cull(Rect clipRect, bool validRect);

		void SetClipRect(Rect value, bool validRect);

		void SetClipSoftness(Vector2 clipSoftness);
	}
}
