using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct InputMotionData_t
{
	public float rotQuatX;

	public float rotQuatY;

	public float rotQuatZ;

	public float rotQuatW;

	public float posAccelX;

	public float posAccelY;

	public float posAccelZ;

	public float rotVelX;

	public float rotVelY;

	public float rotVelZ;
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(143)]
	public struct ValidateAuthTicketResponse_t
	{
		public const int k_iCallback = 143;

		public CSteamID m_SteamID;

		public EAuthSessionResponse m_eAuthSessionResponse;

		public CSteamID m_OwnerSteamID;
	}
}
