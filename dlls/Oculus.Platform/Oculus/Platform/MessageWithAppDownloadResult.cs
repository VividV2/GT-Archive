using System;
using Oculus.Platform.Models;
using System;
using System;

namespace Oculus.Platform
{
	public class MessageWithAppDownloadResult : Message<AppDownloadResult>
	{
		public MessageWithAppDownloadResult(IntPtr c_message)
			: base(c_message)
		{
		}

		public override AppDownloadResult GetAppDownloadResult()
		{
			return base.Data;
		}

		protected override AppDownloadResult GetDataFromMessage(IntPtr c_message)
		{
			return new AppDownloadResult(CAPI.ovr_Message_GetAppDownloadResult(CAPI.ovr_Message_GetNativeMessage(c_message)));
		}
	}
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
