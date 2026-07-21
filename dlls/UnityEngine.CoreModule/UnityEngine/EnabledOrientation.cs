using UnityEngine.Scripting;
using UnityEngine.Scripting;

namespace UnityEngine
{
	[RequiredByNativeCode]
	public interface ISerializationCallbackReceiver
	{
		[RequiredByNativeCode]
		void OnBeforeSerialize();

		[RequiredByNativeCode]
		void OnAfterDeserialize();
	}
}
namespace UnityEngine
{
	internal enum EnabledOrientation
	{
		kAutorotateToPortrait = 1,
		kAutorotateToPortraitUpsideDown = 2,
		kAutorotateToLandscapeLeft = 4,
		kAutorotateToLandscapeRight = 8
	}
}
namespace UnityEngine
{
}
namespace UnityEngine
{
}
