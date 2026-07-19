using System;
using System;

namespace Oculus.Platform.Models;

public class AbuseReportRecording(IntPtr o)
{
	public readonly string RecordingUuid = CAPI.ovr_AbuseReportRecording_GetRecordingUuid(o);
}
