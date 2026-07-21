using System;

namespace UnityEngine;

public struct D3D12DeviceFilterData
{
	public string vendorName;

	public string deviceName;

	public D3D12Comparator driverVersionComparator;

	public string driverVersion;

	public D3D12Comparator featureLevelComparator;

	public string featureLevel;

	public D3D12Comparator graphicsMemoryComparator;

	public string graphicsMemory;

	public D3D12Comparator processorCountComparator;

	public string processorCount;

	public D3D12GraphicsDeviceType deviceType;
}
namespace UnityEngine
{
	[Obsolete("This property has been deprecated. Use LightType.Spot, LightType.Pyramid, or LightType.Box instead.")]
	public enum LightShape
	{
		Cone,
		Pyramid,
		Box
	}
}
