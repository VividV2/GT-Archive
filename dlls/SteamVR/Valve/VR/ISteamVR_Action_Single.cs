namespace Valve.VR
{
	public enum SteamVR_Skeleton_FingerExtensionTypes
	{
		Static,
		Free,
		Extend,
		Contract
	}
}
namespace Valve.VR
{
	public enum SteamVR_Input_ActionScopes
	{
		ActionSet,
		Application,
		Global
	}
}
namespace Valve.VR
{
	public interface ISteamVR_Action_Single : ISteamVR_Action_In_Source, ISteamVR_Action_Source
	{
		float axis { get; }

		float lastAxis { get; }

		float delta { get; }

		float lastDelta { get; }
	}
}
