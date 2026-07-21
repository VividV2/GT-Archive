namespace Oculus.Platform.Models;

public class BlockedUser
{
	public readonly ulong Id;

	public BlockedUser(IntPtr o)
	{
		base..ctor();
		Id = CAPI.ovr_BlockedUser_GetId(o);
	}
}
