using System;
using System.Runtime.InteropServices;

namespace Meta.XR.Acoustics
{
	public enum FaceType : uint
	{
		TRIANGLES,
		QUADS
	}
}
namespace Meta.XR.Acoustics
{
	public enum MaterialProperty : uint
	{
		ABSORPTION,
		TRANSMISSION,
		SCATTERING
	}
}
namespace Meta.XR.Acoustics
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct MeshGroup
	{
		public UIntPtr indexOffset;

		public UIntPtr faceCount;

		[MarshalAs(UnmanagedType.U4)]
		public FaceType faceType;

		public IntPtr material;
	}
}
