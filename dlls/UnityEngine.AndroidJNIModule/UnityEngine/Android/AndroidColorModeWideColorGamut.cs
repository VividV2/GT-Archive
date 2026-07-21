namespace UnityEngine.Android
{
	public enum AndroidColorModeWideColorGamut
	{
		Undefined,
		No,
		Yes
	}
}
namespace UnityEngine.Android
{
	[NativeType(Header = "Modules/AndroidJNI/Public/GameStateHelper.h")]
	public enum AndroidGameState
	{
		Unknown,
		None,
		GamePlayInterruptible,
		GamePlayUninterruptible,
		Content
	}
}
