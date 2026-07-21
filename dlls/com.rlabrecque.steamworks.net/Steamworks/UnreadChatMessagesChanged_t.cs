using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
[CallbackIdentity(4105)]
public struct MusicPlayerWantsPlay_t
{
	public const int k_iCallback = 4105;
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 8, Size = 1)]
	[CallbackIdentity(348)]
	public struct UnreadChatMessagesChanged_t
	{
		public const int k_iCallback = 348;
	}
}
