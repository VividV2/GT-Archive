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
	[CallbackIdentity(1321)]
	public struct RemoteStoragePublishedFileSubscribed_t
	{
		public const int k_iCallback = 1321;

		public PublishedFileId_t m_nPublishedFileId;

		public AppId_t m_nAppID;
	}
}
