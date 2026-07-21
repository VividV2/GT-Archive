namespace Steamworks
{
	public enum ESNetSocketState
	{
		k_ESNetSocketStateInvalid = 0,
		k_ESNetSocketStateConnected = 1,
		k_ESNetSocketStateInitiated = 10,
		k_ESNetSocketStateLocalCandidatesFound = 11,
		k_ESNetSocketStateReceivedRemoteCandidates = 12,
		k_ESNetSocketStateChallengeHandshake = 15,
		k_ESNetSocketStateDisconnecting = 21,
		k_ESNetSocketStateLocalDisconnect = 22,
		k_ESNetSocketStateTimeoutDuringConnect = 23,
		k_ESNetSocketStateRemoteEndDisconnected = 24,
		k_ESNetSocketStateConnectionBroken = 25
	}
}
namespace Steamworks
{
	public enum EInputSourceMode
	{
		k_EInputSourceMode_None,
		k_EInputSourceMode_Dpad,
		k_EInputSourceMode_Buttons,
		k_EInputSourceMode_FourButtons,
		k_EInputSourceMode_AbsoluteMouse,
		k_EInputSourceMode_RelativeMouse,
		k_EInputSourceMode_JoystickMove,
		k_EInputSourceMode_JoystickMouse,
		k_EInputSourceMode_JoystickCamera,
		k_EInputSourceMode_ScrollWheel,
		k_EInputSourceMode_Trigger,
		k_EInputSourceMode_TouchMenu,
		k_EInputSourceMode_MouseJoystick,
		k_EInputSourceMode_MouseRegion,
		k_EInputSourceMode_RadialMenu,
		k_EInputSourceMode_SingleButton,
		k_EInputSourceMode_Switches
	}
}
namespace Steamworks
{
	public enum EUserRestriction
	{
		k_nUserRestrictionNone = 0,
		k_nUserRestrictionUnknown = 1,
		k_nUserRestrictionAnyChat = 2,
		k_nUserRestrictionVoiceChat = 4,
		k_nUserRestrictionGroupChat = 8,
		k_nUserRestrictionRating = 0x10,
		k_nUserRestrictionGameInvites = 0x20,
		k_nUserRestrictionTrading = 0x40
	}
}
namespace Steamworks
{
	public enum AudioPlayback_Status
	{
		AudioPlayback_Undefined,
		AudioPlayback_Playing,
		AudioPlayback_Paused,
		AudioPlayback_Idle
	}
}
namespace Steamworks
{
}
