using System;
using System;

namespace Oculus.Platform.Models;

public class SendInvitesResult(IntPtr o)
{
	public readonly ApplicationInviteList Invites = new ApplicationInviteList(CAPI.ovr_SendInvitesResult_GetInvites(o));
}
