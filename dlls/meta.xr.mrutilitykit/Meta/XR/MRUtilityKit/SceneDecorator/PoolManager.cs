using System.Collections.Generic;
using Meta.XR.Util;
using UnityEngine;
using Meta.XR.Util;
using UnityEngine;

namespace Meta.XR.MRUtilityKit.SceneDecorator
{
	[Feature(Feature.Scene)]
	public class PoolManager<K, P> where K : class where P : Pool<K>
	{
		private Dictionary<K, P> pools = new Dictionary<K, P>();

		public void AddPool(K primitive, P pool)
		{
			pools.Add(primitive, pool);
		}

		public bool ContainsPool(K primitive)
		{
			return pools.ContainsKey(primitive);
		}

		public P GetPool(K primitive)
		{
			pools.TryGetValue(primitive, out var value);
			return value;
		}
	}
}
namespace Meta.XR.MRUtilityKit.SceneDecorator
{
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
}
