using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine;

namespace GT_CustomMapSupportRuntime
{
	public struct WaterVolumeProperties
	{
		public Transform? surfacePlane;

		public List<MeshCollider> surfaceColliders;

		public CMSZoneShaderSettings.EZoneLiquidType liquidType;
	}
}
namespace GT_CustomMapSupportRuntime
{
	public struct ForceVolumeProperties
	{
		public float accel;

		public float maxDepth;

		public float maxSpeed;

		public bool disableGrip;

		public bool dampenLateralVelocity;

		public float dampenXVel;

		public float dampenZVel;

		public bool applyPullToCenterAcceleration;

		public float pullToCenterAccel;

		public float pullToCenterMaxSpeed;

		public float pullToCenterMinDistance;

		public AudioClip? enterClip;

		public AudioClip? exitClip;

		public AudioClip? loopClip;

		public AudioClip? loopCrescendoClip;
	}
}
namespace GT_CustomMapSupportRuntime
{
}
