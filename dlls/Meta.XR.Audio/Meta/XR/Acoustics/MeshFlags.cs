using System;
using System.Runtime.InteropServices;
using System;

namespace Meta.XR.Acoustics
{
	[Flags]
	public enum MeshFlags : uint
	{
		NONE = 0u,
		ENABLE_SIMPLIFICATION = 1u,
		ENABLE_DIFFRACTION = 2u
	}
}
namespace Meta.XR.Acoustics
{
	[System.Runtime.InteropServices.UnmanagedFunctionPointer(System.Runtime.InteropServices.CallingConvention.Cdecl)]
	public delegate bool ProgressCallback(IntPtr userData, string description, float progress);
}
