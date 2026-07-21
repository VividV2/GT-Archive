using System;
using System;

namespace Oculus.Platform
{
}
namespace Oculus.Platform.Models
{
	public class AssetFileDownloadUpdate(IntPtr o)
	{
		public readonly ulong AssetFileId = CAPI.ovr_AssetFileDownloadUpdate_GetAssetFileId(o);

		public readonly ulong AssetId = CAPI.ovr_AssetFileDownloadUpdate_GetAssetId(o);

		public readonly ulong BytesTotal = CAPI.ovr_AssetFileDownloadUpdate_GetBytesTotalLong(o);

		public readonly long BytesTransferred = CAPI.ovr_AssetFileDownloadUpdate_GetBytesTransferredLong(o);

		public readonly bool Completed = CAPI.ovr_AssetFileDownloadUpdate_GetCompleted(o);
	}
}
