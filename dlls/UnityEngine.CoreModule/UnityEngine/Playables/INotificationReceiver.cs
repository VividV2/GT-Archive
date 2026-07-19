using UnityEngine.Scripting;

namespace UnityEngine
{
	public enum FindObjectsSortMode
	{
		None,
		InstanceID
	}
}
namespace UnityEngine.Playables
{
	[RequiredByNativeCode]
	public interface INotificationReceiver
	{
		[RequiredByNativeCode]
		void OnNotify(Playable origin, INotification notification, object context);
	}
}
namespace UnityEngine
{
}
