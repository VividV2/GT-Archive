using System.Collections.Generic;
using UnityEngine;
using UnityEngine;

namespace GT_CustomMapSupportRuntime;

public struct GliderWindVolumeProperties
{
	public float maxSpeed;

	public float maxAccel;

	public AnimationCurve speedVsAccelCurve;

	public Vector3 localWindDirection;
}
namespace GT_CustomMapSupportRuntime
{
	[RequireComponent(typeof(BoxCollider))]
	[DisallowMultipleComponent]
	public class LoadZoneSettings : MonoBehaviour
	{
		public bool useDynamicLighting = false;

		public Color UberShaderAmbientDynamicLight = Color.black;

		public List<string> scenesToLoad = new List<string>();

		public List<string> scenesToUnload = new List<string>();
	}
}
namespace GT_CustomMapSupportRuntime
{
}
