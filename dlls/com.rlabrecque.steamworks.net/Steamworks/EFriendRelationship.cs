using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace Steamworks
{
	public enum ELobbyDistanceFilter
	{
		k_ELobbyDistanceFilterClose,
		k_ELobbyDistanceFilterDefault,
		k_ELobbyDistanceFilterFar,
		k_ELobbyDistanceFilterWorldwide
	}
}
namespace Steamworks
{
	public enum EFriendRelationship
	{
		k_EFriendRelationshipNone,
		k_EFriendRelationshipBlocked,
		k_EFriendRelationshipRequestRecipient,
		k_EFriendRelationshipFriend,
		k_EFriendRelationshipRequestInitiator,
		k_EFriendRelationshipIgnored,
		k_EFriendRelationshipIgnoredFriend,
		k_EFriendRelationshipSuggested_DEPRECATED,
		k_EFriendRelationshipMax
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(334)]
	public struct AvatarImageLoaded_t
	{
		public const int k_iCallback = 334;

		public CSteamID m_steamID;

		public int m_iImage;

		public int m_iWide;

		public int m_iTall;
	}
}
