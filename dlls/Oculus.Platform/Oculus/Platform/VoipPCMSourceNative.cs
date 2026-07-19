using System;
using System;

namespace Oculus.Platform.Models
{
	public class AppDownloadResult(IntPtr o)
	{
		public readonly AppInstallResult AppInstallResult = CAPI.ovr_AppDownloadResult_GetAppInstallResult(o);

		public readonly long Timestamp = CAPI.ovr_AppDownloadResult_GetTimestamp(o);
	}
}
namespace Oculus.Platform.Models
{
}
