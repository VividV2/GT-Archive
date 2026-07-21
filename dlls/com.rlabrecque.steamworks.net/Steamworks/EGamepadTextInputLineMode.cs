namespace Steamworks
{
	public enum EGamepadTextInputLineMode
	{
		k_EGamepadTextInputLineModeSingleLine,
		k_EGamepadTextInputLineModeMultipleLines
	}
}
namespace Steamworks
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	[CallbackIdentity(342)]
	public struct JoinClanChatRoomCompletionResult_t
	{
		public const int k_iCallback = 342;

		public CSteamID m_steamIDClanChat;

		public EChatRoomEnterResponse m_eChatRoomEnterResponse;
	}
}
