using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(4106)]
	public struct MusicPlayerWantsPause_t
	{
		public const int k_iCallback = 4106;
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(4511)]
	public struct HTML_HorizontalScroll_t
	{
		public const int k_iCallback = 4511;

		public HHTMLBrowser unBrowserHandle;

		public uint unScrollMax;

		public uint unScrollCurrent;

		public float flPageScale;

		[MarshalAs(UnmanagedType.I1)]
		public bool bVisible;

		public uint unPageSize;
	}
}
