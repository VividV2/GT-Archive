namespace Steamworks
{
}
namespace Steamworks
{
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4704)]
	public struct SteamInventoryStartPurchaseResult_t
	{
		public const int k_iCallback = 4704;

		public EResult m_result;

		public ulong m_ulOrderID;

		public ulong m_ulTransID;
	}
}
namespace Steamworks
{
}
namespace Steamworks
{
}
namespace Steamworks
{
	public enum EActivateGameOverlayToWebPageMode
	{
		k_EActivateGameOverlayToWebPageMode_Default,
		k_EActivateGameOverlayToWebPageMode_Modal
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1102)]
	public struct UserStatsStored_t
	{
		public const int k_iCallback = 1102;

		public ulong m_nGameID;

		public EResult m_eResult;
	}
}
namespace Steamworks
{
}
