using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3414)]
	public struct AddAppDependencyResult_t
	{
		public const int k_iCallback = 3414;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(3406)]
	public struct DownloadItemResult_t
	{
		public const int k_iCallback = 3406;

		public AppId_t m_unAppID;

		public PublishedFileId_t m_nPublishedFileId;

		public EResult m_eResult;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1109)]
	public struct UserAchievementIconFetched_t
	{
		public const int k_iCallback = 1109;

		public CGameID m_nGameID;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 128)]
		private byte[] m_rgchAchievementName_;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bAchieved;

		public int m_nIconHandle;

		public string m_rgchAchievementName
		{
			get
			{
				return InteropHelp.ByteArrayToStringUTF8(m_rgchAchievementName_);
			}
			set
			{
				InteropHelp.StringToByteArrayUTF8(value, m_rgchAchievementName_, 128);
			}
		}
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	[CallbackIdentity(1203)]
	public struct P2PSessionConnectFail_t
	{
		public const int k_iCallback = 1203;

		public CSteamID m_steamIDRemote;

		public byte m_eP2PSessionError;
	}
}
namespace Steamworks
{
	public enum ECommunityProfileItemProperty
	{
		k_ECommunityProfileItemProperty_ImageSmall,
		k_ECommunityProfileItemProperty_ImageLarge,
		k_ECommunityProfileItemProperty_InternalName,
		k_ECommunityProfileItemProperty_Title,
		k_ECommunityProfileItemProperty_Description,
		k_ECommunityProfileItemProperty_AppID,
		k_ECommunityProfileItemProperty_TypeID,
		k_ECommunityProfileItemProperty_Class,
		k_ECommunityProfileItemProperty_MovieWebM,
		k_ECommunityProfileItemProperty_MovieMP4,
		k_ECommunityProfileItemProperty_MovieWebMSmall,
		k_ECommunityProfileItemProperty_MovieMP4Small
	}
}
