using System;
using System.Runtime.InteropServices;

namespace OVR.OpenVR
{
	public struct HmdVector2_t
	{
		public float v0;

		public float v1;
	}
}
namespace OVR.OpenVR
{
}
namespace OVR.OpenVR
{
	public struct HmdMatrix34_t
	{
		public float m0;

		public float m1;

		public float m2;

		public float m3;

		public float m4;

		public float m5;

		public float m6;

		public float m7;

		public float m8;

		public float m9;

		public float m10;

		public float m11;
	}
}
namespace OVR.OpenVR
{
}
[StructLayout(LayoutKind.Sequential, Size = 1)]
internal struct OVRProfilerScope : IDisposable
{
	public OVRProfilerScope(string name)
	{
	}

	void IDisposable.Dispose()
	{
	}
}
