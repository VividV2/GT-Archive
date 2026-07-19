using System;
using System;

namespace Oculus.Platform.Models;

public class AvatarEditorResult(IntPtr o)
{
	public readonly bool RequestSent = CAPI.ovr_AvatarEditorResult_GetRequestSent(o);
}
