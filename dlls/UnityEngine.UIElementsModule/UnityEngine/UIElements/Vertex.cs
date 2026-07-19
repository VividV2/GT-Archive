using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using System.Runtime.InteropServices;
using UnityEngine.Bindings;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements
{
	[VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal interface IPrefixLabel
	{
		string label { get; }

		Label labelElement { get; }
	}
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements
{
	public struct Vertex
	{
		public static readonly float nearZ;

		public Vector3 position;

		public Color32 tint;

		public Vector2 uv;

		internal Color32 xformClipPages;

		internal Color32 ids;

		internal Color32 flags;

		internal Color32 opacityColorPages;

		internal Color32 settingIndex;

		internal Vector4 circle;

		internal float textureId;
	}
}
namespace UnityEngine.UIElements
{
}
namespace UnityEngine.UIElements
{
	[NativeType(Header = "Modules/UIElements/VisualNodeImguiData.h")]
	internal struct VisualNodeImguiData
	{
		[MarshalAs(UnmanagedType.U1)]
		public bool IsContainer;

		public int DescendantCount;
	}
}
