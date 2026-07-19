using System;
using PlayFab.SharedModels;

namespace PlayFab.ClientModels
{
	[Serializable]
	public class RegionInfo : PlayFabBaseModel
	{
		public bool Available;

		public string Name;

		public string PingUrl;

		public Region? Region;
	}
}
namespace PlayFab.ClientModels
{
}
namespace PlayFab.ClientModels
{
	public enum LoginIdentityProvider
	{
		Unknown,
		PlayFab,
		Custom,
		GameCenter,
		GooglePlay,
		Steam,
		XBoxLive,
		PSN,
		Kongregate,
		Facebook,
		IOSDevice,
		AndroidDevice,
		Twitch,
		WindowsHello,
		GameServer,
		CustomServer,
		NintendoSwitch,
		FacebookInstantGames,
		OpenIdConnect,
		Apple,
		NintendoSwitchAccount
	}
}
