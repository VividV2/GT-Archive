using System;
using System;

namespace Oculus.Platform.Models;

public class PlatformInitialize(IntPtr o)
{
	public readonly PlatformInitializeResult Result = CAPI.ovr_PlatformInitialize_GetResult(o);
}
