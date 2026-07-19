using System;
using UnityEngine;
using System;

namespace Unity.Multiplayer.Center.Common;

[Serializable]
public class SelectedSolutionsData
{
	public enum HostingModel
	{
		None,
		ClientHosted,
		DedicatedServer,
		CloudCode,
		DistributedAuthority
	}

	public enum NetcodeSolution
	{
		None,
		NGO,
		N4E,
		CustomNetcode,
		NoNetcode
	}

	public HostingModel SelectedHostingModel;

	public NetcodeSolution SelectedNetcodeSolution;
}
namespace Unity.Multiplayer.Center.Common
{
	[Serializable]
	[InspectorOrder(InspectorSort.ByName, InspectorSortDirection.Ascending)]
	public enum Preset
	{
		[InspectorName("-")]
		None,
		[InspectorName("Adventure")]
		Adventure,
		[InspectorName("Shooter, Battle Royale, Battle Arena")]
		Shooter,
		[InspectorName("Racing")]
		Racing,
		[InspectorName("Card Battle, Turn-based, Tabletop")]
		TurnBased,
		[InspectorName("Simulation")]
		Simulation,
		[InspectorName("Strategy")]
		Strategy,
		[InspectorName("Sports")]
		Sports,
		[InspectorName("Role-Playing, MMO")]
		RolePlaying,
		[InspectorName("Async, Idle, Hyper Casual, Puzzle")]
		Async,
		[InspectorName("Fighting")]
		Fighting,
		[InspectorName("Arcade, Platformer, Sandbox")]
		Sandbox
	}
}
