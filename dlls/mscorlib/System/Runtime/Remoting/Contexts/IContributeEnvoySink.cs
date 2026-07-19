namespace System.Runtime.InteropServices;

/// <summary>Use <see cref="T:System.Runtime.InteropServices.ComTypes.IEnumMoniker" /> instead.</summary>
[ComImport]
[Obsolete]
[Guid("00000102-0000-0000-c000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface UCOMIEnumMoniker
{
	/// <summary>Retrieves a specified number of items in the enumeration sequence.</summary>
	/// <param name="celt">The number of monikers to return in <paramref name="rgelt" />.</param>
	/// <param name="rgelt">On successful return, a reference to the enumerated monikers.</param>
	/// <param name="pceltFetched">On successful return, a reference to the actual number of monikers enumerated in <paramref name="rgelt" />.</param>
	/// <returns>
	///   <see langword="S_OK" /> if the <paramref name="pceltFetched" /> parameter equals the <paramref name="celt" /> parameter; otherwise, <see langword="S_FALSE" />.</returns>
	[PreserveSig]
	int Next(int celt, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] UCOMIMoniker[] rgelt, out int pceltFetched);

	[PreserveSig]
	int Skip(int celt);

	[PreserveSig]
	int Reset();

	void Clone(out UCOMIEnumMoniker ppenum);
}
