using System;
using System;
using System;

namespace Oculus.Platform.Models;

public class RejoinDialogResult(IntPtr o)
{
	public readonly bool RejoinSelected = CAPI.ovr_RejoinDialogResult_GetRejoinSelected(o);
}
