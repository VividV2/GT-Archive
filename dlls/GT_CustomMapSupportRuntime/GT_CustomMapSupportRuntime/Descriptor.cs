using Newtonsoft.Json;
using UnityEngine.Scripting;

namespace GT_CustomMapSupportRuntime;

public enum ExportLightingType
{
	Default_Unity,
	Alternative,
	Off
}
namespace GT_CustomMapSupportRuntime
{
	[Preserve]
	public class Descriptor
	{
		[JsonProperty(PropertyName = "objectName")]
		public string objectName = "";

		[JsonConstructor]
		public Descriptor()
		{
		}
	}
}
