using System;
using System;

namespace UnityEngine
{
	public struct D3D12GraphicsJobsDeviceFilterData
	{
		public GraphicsJobsFilterMode preferredMode;

		public D3D12DeviceFilterData filter;
	}
}
namespace UnityEngine
{
	[Flags]
	public enum SnapAxis : byte
	{
		None = 0,
		X = 1,
		Y = 2,
		Z = 4,
		All = 7
	}
}
