using System;
using System;

namespace Oculus.Platform.Models
{
	public class PushNotificationResult(IntPtr o)
	{
		public readonly string Id = CAPI.ovr_PushNotificationResult_GetId(o);
	}
}
namespace Oculus.Platform.Models
{
}
