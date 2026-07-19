using UnityEngine.Bindings;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal struct ImageSource
	{
		public Texture2D texture;

		public Sprite sprite;

		public VectorImage vectorImage;

		public RenderTexture renderTexture;

		public bool IsNull()
		{
			return texture == null && sprite == null && vectorImage == null && renderTexture == null;
		}
	}
}
namespace UnityEngine.UIElements.Layout
{
	internal delegate float LayoutBaselineFunction(ref LayoutNode node, float width, float height);
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements.UIR
{
}
