using System;
using System.Runtime.InteropServices;
using System;
using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
public struct CallbackMsg_t
{
	public int m_hSteamUser;

	public int m_iCallback;

	public IntPtr m_pubParam;

	public int m_cubParam;
}
namespace Steamworks
{
	[UnmanagedFunctionPointer(CallingConvention.StdCall)]
	public delegate void SteamAPI_CheckCallbackRegistered_t(int iCallbackNum);
}
