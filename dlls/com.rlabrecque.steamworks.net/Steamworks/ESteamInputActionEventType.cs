namespace Steamworks
{
	public enum EXboxOrigin
	{
		k_EXboxOrigin_A,
		k_EXboxOrigin_B,
		k_EXboxOrigin_X,
		k_EXboxOrigin_Y,
		k_EXboxOrigin_LeftBumper,
		k_EXboxOrigin_RightBumper,
		k_EXboxOrigin_Menu,
		k_EXboxOrigin_View,
		k_EXboxOrigin_LeftTrigger_Pull,
		k_EXboxOrigin_LeftTrigger_Click,
		k_EXboxOrigin_RightTrigger_Pull,
		k_EXboxOrigin_RightTrigger_Click,
		k_EXboxOrigin_LeftStick_Move,
		k_EXboxOrigin_LeftStick_Click,
		k_EXboxOrigin_LeftStick_DPadNorth,
		k_EXboxOrigin_LeftStick_DPadSouth,
		k_EXboxOrigin_LeftStick_DPadWest,
		k_EXboxOrigin_LeftStick_DPadEast,
		k_EXboxOrigin_RightStick_Move,
		k_EXboxOrigin_RightStick_Click,
		k_EXboxOrigin_RightStick_DPadNorth,
		k_EXboxOrigin_RightStick_DPadSouth,
		k_EXboxOrigin_RightStick_DPadWest,
		k_EXboxOrigin_RightStick_DPadEast,
		k_EXboxOrigin_DPad_North,
		k_EXboxOrigin_DPad_South,
		k_EXboxOrigin_DPad_West,
		k_EXboxOrigin_DPad_East,
		k_EXboxOrigin_Count
	}
}
namespace Steamworks
{
	public enum ESteamInputActionEventType
	{
		ESteamInputActionEventType_DigitalAction,
		ESteamInputActionEventType_AnalogAction
	}
}
namespace Steamworks
{
	public enum EUGCMatchingUGCType
	{
		k_EUGCMatchingUGCType_Items = 0,
		k_EUGCMatchingUGCType_Items_Mtx = 1,
		k_EUGCMatchingUGCType_Items_ReadyToUse = 2,
		k_EUGCMatchingUGCType_Collections = 3,
		k_EUGCMatchingUGCType_Artwork = 4,
		k_EUGCMatchingUGCType_Videos = 5,
		k_EUGCMatchingUGCType_Screenshots = 6,
		k_EUGCMatchingUGCType_AllGuides = 7,
		k_EUGCMatchingUGCType_WebGuides = 8,
		k_EUGCMatchingUGCType_IntegratedGuides = 9,
		k_EUGCMatchingUGCType_UsableInGame = 10,
		k_EUGCMatchingUGCType_ControllerBindings = 11,
		k_EUGCMatchingUGCType_GameManagedItems = 12,
		k_EUGCMatchingUGCType_All = -1
	}
}
namespace Steamworks
{
	public enum ETimelineGameMode
	{
		k_ETimelineGameMode_Invalid,
		k_ETimelineGameMode_Playing,
		k_ETimelineGameMode_Staging,
		k_ETimelineGameMode_Menus,
		k_ETimelineGameMode_LoadingScreen,
		k_ETimelineGameMode_Max
	}
}
