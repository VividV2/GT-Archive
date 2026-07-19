using System;
using System;

namespace Oculus.Platform.Models;

public class LinkedAccount(IntPtr o)
{
	public readonly string AccessToken = CAPI.ovr_LinkedAccount_GetAccessToken(o);

	public readonly ServiceProvider ServiceProvider = CAPI.ovr_LinkedAccount_GetServiceProvider(o);

	public readonly string UserId = CAPI.ovr_LinkedAccount_GetUserId(o);
}
