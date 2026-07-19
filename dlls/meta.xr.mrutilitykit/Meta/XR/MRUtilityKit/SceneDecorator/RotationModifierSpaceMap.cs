using Meta.XR.Util;
using UnityEngine;
using Meta.XR.Util;
using UnityEngine;

namespace Meta.XR.MRUtilityKit.SceneDecorator;

[Feature(Feature.Scene)]
public class KeepUprightWithSurfaceModifier : Modifier
{
	[SerializeField]
	public Vector3 uprightAxis = new Vector3(0f, 1f, 0f);

	public override void ApplyModifier(GameObject decorationGO, MRUKAnchor sceneAnchor, SceneDecoration sceneDecoration, Candidate candidate)
	{
		Quaternion rotation = decorationGO.transform.rotation;
		Quaternion rotation;
		Vector3 fromDirection = rotation * uprightAxis;
		Vector3 fromDirection;
		rotation *= Quaternion.FromToRotation(fromDirection, candidate.hit.normal);
		decorationGO.transform.rotation = rotation;
	}
}
