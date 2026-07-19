using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks;

[StructLayout(LayoutKind.Sequential, Pack = 8)]
[CallbackIdentity(1108)]
public struct UserStatsUnloaded_t
{
	public const int k_iCallback = 1108;

	public CSteamID m_steamIDUser;
}
namespace Steamworks
{
	public enum ECommunityProfileItemType
	{
		k_ECommunityProfileItemType_AnimatedAvatar,
		k_ECommunityProfileItemType_AvatarFrame,
		k_ECommunityProfileItemType_ProfileModifier,
		k_ECommunityProfileItemType_ProfileBackground,
		k_ECommunityProfileItemType_MiniProfileBackground
	}
}
