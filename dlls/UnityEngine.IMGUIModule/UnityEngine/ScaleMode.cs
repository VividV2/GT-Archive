using System;

namespace UnityEngine
{
	public enum FocusType
	{
		[System.Obsolete("FocusType.Native now behaves the same as FocusType.Passive in all OS cases. (UnityUpgradable) -> Passive", false)]
		Native,
		Keyboard,
		Passive
	}
}
namespace UnityEngine
{
	public enum ScaleMode
	{
		StretchToFill,
		ScaleAndCrop,
		ScaleToFit
	}
}
