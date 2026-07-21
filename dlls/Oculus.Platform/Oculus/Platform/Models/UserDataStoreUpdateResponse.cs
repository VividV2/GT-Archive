using System;

namespace Oculus.Platform.Models
{
	public class UserDataStoreUpdateResponse
	{
		public readonly bool Success;

		public UserDataStoreUpdateResponse(IntPtr o)
		{
			Success = CAPI.ovr_UserDataStoreUpdateResponse_GetSuccess(o);
		}
	}
}
namespace Oculus.Platform.Models
{
	public class PushNotificationResult
	{
		public readonly string Id;

		public PushNotificationResult(IntPtr o)
		{
			Id = CAPI.ovr_PushNotificationResult_GetId(o);
		}
	}
}
