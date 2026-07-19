using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4101)]
	public struct MusicPlayerRemoteWillActivate_t
	{
		public const int k_iCallback = 4101;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(1309)]
	public struct RemoteStoragePublishFileResult_t
	{
		public const int k_iCallback = 1309;

		public EResult m_eResult;

		public PublishedFileId_t m_nPublishedFileId;

		[MarshalAs(UnmanagedType.I1)]
		public bool m_bUserNeedsToAcceptWorkshopLegalAgreement;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4502)]
	public struct HTML_NeedsPaint_t
	{
		public const int k_iCallback = 4502;

		public HHTMLBrowser unBrowserHandle;

		public System.IntPtr pBGRA;

		public uint unWide;

		public uint unTall;

		public uint unUpdateX;

		public uint unUpdateY;

		public uint unUpdateWide;

		public uint unUpdateTall;

		public uint unScrollX;

		public uint unScrollY;

		public float flPageScale;

		public uint unPageSerial;
	}
}
