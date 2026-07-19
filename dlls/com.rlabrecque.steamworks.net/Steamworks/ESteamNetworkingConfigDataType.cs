using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(201)]
	public struct GSClientApprove_t
	{
		public const int k_iCallback = 201;

		public CSteamID m_SteamID;

		public CSteamID m_OwnerSteamID;
	}
}
namespace Steamworks
{
	public enum ESteamNetworkingConfigDataType
	{
		k_ESteamNetworkingConfig_Int32 = 1,
		k_ESteamNetworkingConfig_Int64 = 2,
		k_ESteamNetworkingConfig_Float = 3,
		k_ESteamNetworkingConfig_String = 4,
		k_ESteamNetworkingConfig_Ptr = 5,
		k_ESteamNetworkingConfigDataType__Force32Bit = int.MaxValue
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(5305)]
	public struct AvailableBeaconLocationsUpdated_t
	{
		public const int k_iCallback = 5305;
	}
}
