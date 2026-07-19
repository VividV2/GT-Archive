using System;
using System;

namespace Oculus.Platform.Models;

public class UserCapability(IntPtr o)
{
	public readonly string Description = CAPI.ovr_UserCapability_GetDescription(o);

	public readonly bool IsEnabled = CAPI.ovr_UserCapability_GetIsEnabled(o);

	public readonly string Name = CAPI.ovr_UserCapability_GetName(o);

	public readonly string ReasonCode = CAPI.ovr_UserCapability_GetReasonCode(o);
}
