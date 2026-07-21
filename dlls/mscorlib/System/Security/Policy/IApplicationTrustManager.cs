namespace System.Runtime.InteropServices;

/// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.BINDPTR" /> instead.</summary>
[StructLayout(LayoutKind.Explicit, CharSet = CharSet.Unicode)]
[Obsolete]
public struct BINDPTR
{
	[FieldOffset(0)]
	public IntPtr lpfuncdesc;

	[FieldOffset(0)]
	public IntPtr lptcomp;

	[FieldOffset(0)]
	public IntPtr lpvardesc;
}
