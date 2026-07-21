using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(115)]
	public struct GSPolicyResponse_t
	{
		public const int k_iCallback = 115;

		public byte m_bSecure;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1313)]
	public struct RemoteStorageSubscribePublishedFileResult_t
	{
		public const int k_iCallback = 1313;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;
	}
}
