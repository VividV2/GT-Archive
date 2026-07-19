using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum ESteamInputConfigurationEnableType
	{
		k_ESteamInputConfigurationEnableType_None = 0,
		k_ESteamInputConfigurationEnableType_Playstation = 1,
		k_ESteamInputConfigurationEnableType_Xbox = 2,
		k_ESteamInputConfigurationEnableType_Generic = 4,
		k_ESteamInputConfigurationEnableType_Switch = 8
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(702)]
	public struct LowBatteryPower_t
	{
		public const int k_iCallback = 702;

		public byte m_nMinutesBatteryLeft;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3412)]
	public struct AddUGCDependencyResult_t
	{
		public const int k_iCallback = 3412;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public PublishedFileId_t m_nChildPublishedFileId;
	}
}
namespace Steamworks
{
}
