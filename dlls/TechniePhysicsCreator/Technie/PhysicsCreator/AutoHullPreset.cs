using UnityEngine;
using UnityEngine;

namespace Technie.PhysicsCreator
{
	public interface ICreatorComponent
	{
		GameObject GetGameObject();

		bool HasEditorData();

		IEditorData GetEditorData();
	}
}
namespace Technie.PhysicsCreator
{
}
namespace Technie.PhysicsCreator
{
	public enum AutoHullPreset
	{
		Low,
		Medium,
		High,
		Placebo,
		Custom
	}
}
