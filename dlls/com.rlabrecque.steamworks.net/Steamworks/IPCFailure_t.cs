using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(117)]
	public struct IPCFailure_t
	{
		public const int k_iCallback = 117;

		public byte m_eFailureType;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4703)]
	public struct SteamInventoryEligiblePromoItemDefIDs_t
	{
		public const int k_iCallback = 4703;

		public EResult m_result;

		public CSteamID m_steamID;

		public int m_numEligiblePromoItemDefs;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bCachedData;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct InputAnalogActionData_t
	{
		public EInputSourceMode eMode;

		public float x;

		public float y;

		public byte bActive;
	}
}
namespace Steamworks
{
}
namespace Steamworks
{
}
