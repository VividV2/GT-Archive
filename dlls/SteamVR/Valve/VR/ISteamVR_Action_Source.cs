namespace Valve.VR
{
	public interface ISteamVR_Action_In : ISteamVR_Action, ISteamVR_Action_Source, ISteamVR_Action_In_Source
	{
		void UpdateValues();

		string GetRenderModelComponentName(SteamVR_Input_Sources inputSource);

		SteamVR_Input_Sources GetActiveDevice(SteamVR_Input_Sources inputSource);

		uint GetDeviceIndex(SteamVR_Input_Sources inputSource);

		bool GetChanged(SteamVR_Input_Sources inputSource);

		string GetLocalizedOriginPart(SteamVR_Input_Sources inputSource, params EVRInputStringBits[] localizedParts);

		string GetLocalizedOrigin(SteamVR_Input_Sources inputSource);
	}
}
namespace Valve.VR
{
	public interface ISteamVR_Action_Source
	{
		bool active { get; }

		bool activeBinding { get; }

		bool lastActive { get; }

		bool lastActiveBinding { get; }

		string fullPath { get; }

		ulong handle { get; }

		SteamVR_ActionSet actionSet { get; }

		SteamVR_ActionDirections direction { get; }
	}
}
namespace Valve.VR.InteractionSystem
{
}
