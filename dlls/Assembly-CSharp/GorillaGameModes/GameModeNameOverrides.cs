using System;
using UnityEngine;
using UnityEngine.Events;
using System;

namespace GorillaGameModes
{
	[Serializable]
	public struct GameModeNameOverrides
	{
		public GameModeType mode;

		public string displayName;
	}
}
namespace PerformanceSystems
{
	public interface ILod
	{
		int CurrentLod { get; }

		Vector3 Position { get; }

		float[] LodRanges { get; }

		UnityEvent[] OnLodRangeEvents { get; }

		UnityEvent OnCulledEvent { get; }

		void UpdateLod(Vector3 refPos);
	}
}
namespace GorillaTagScripts
{
}
