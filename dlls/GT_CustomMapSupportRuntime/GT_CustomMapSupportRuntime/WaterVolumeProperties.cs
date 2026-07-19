using System.Collections.Generic;
using UnityEngine;
using System.Collections.Generic;
using UnityEngine;

namespace GT_CustomMapSupportRuntime
{
	public enum GTObject
	{
		LeafGlider,
		GliderWindVolume,
		WaterVolume,
		ForceVolume,
		ATM,
		HoverboardArea,
		HoverboardDispenser,
		RopeSwing,
		ZipLine,
		Store_DisplayStand,
		Store_TryOnArea,
		Store_Checkout,
		Store_TryOnConsole
	}
}
namespace GT_CustomMapSupportRuntime
{
	public struct WaterVolumeProperties
	{
		public Transform? surfacePlane;

		public List<MeshCollider> surfaceColliders;

		public CMSZoneShaderSettings.EZoneLiquidType liquidType;
	}
}
