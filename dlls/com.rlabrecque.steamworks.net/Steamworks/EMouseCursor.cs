using System.Runtime.InteropServices;

namespace Steamworks
{
	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential, Pack = 8)]
	[CallbackIdentity(347)]
	public struct SetPersonaNameResponse_t
	{
		public const int k_iCallback = 347;

		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
		public bool m_bSuccess;

		[System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.I1)]
		public bool m_bLocalSuccess;

		public EResult m_result;
	}
}
namespace Steamworks
{
}
