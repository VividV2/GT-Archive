using UnityEngine.Scripting.APIUpdating;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Rendering
{
	public struct SubPassDescriptor
	{
		public AttachmentIndexArray inputs;

		public AttachmentIndexArray colorOutputs;

		public SubPassFlags flags;
	}
}
namespace UnityEngine.Rendering
{
	[MovedFrom(true, "UnityEngine.Rendering.HighDefinition", "Unity.RenderPipelines.HighDefinition.Runtime", null)]
	public enum LightUnit
	{
		Lumen,
		Candela,
		Lux,
		Nits,
		Ev100
	}
}
