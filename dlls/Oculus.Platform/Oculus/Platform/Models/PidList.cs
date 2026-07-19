using System;
using System;

namespace Oculus.Platform.Models;

public class LaunchInvitePanelFlowResult(IntPtr o)
{
	public readonly UserList InvitedUsers = new UserList(CAPI.ovr_LaunchInvitePanelFlowResult_GetInvitedUsers(o));
}
