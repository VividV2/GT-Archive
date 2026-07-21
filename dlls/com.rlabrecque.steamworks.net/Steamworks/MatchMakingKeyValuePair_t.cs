using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum ESteamIPType
	{
		k_ESteamIPTypeIPv4,
		k_ESteamIPTypeIPv6
	}
}
namespace Steamworks
{
	public enum ERemoteStorageLocalFileChange
	{
		k_ERemoteStorageLocalFileChange_Invalid,
		k_ERemoteStorageLocalFileChange_FileUpdated,
		k_ERemoteStorageLocalFileChange_FileDeleted
	}
}
namespace Steamworks
{
	public struct MatchMakingKeyValuePair_t
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szKey;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 256)]
		public string m_szValue;

		private MatchMakingKeyValuePair_t(string strKey, string strValue)
		{
			m_szKey = strKey;
			m_szValue = strValue;
		}
	}
}
