namespace System.Runtime.InteropServices;

/// <summary>Exposes the <see cref="T:System.Attribute" /> class to unmanaged code.</summary>
[TypeLibImportClass(typeof(Attribute))]
[ComVisible(true)]
[CLSCompliant(false)]
[Guid("917B14D0-2D9E-38B8-92A9-381ACF52F7C0")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
public interface _Attribute
{
	/// <summary>Maps a set of names to a corresponding set of dispatch identifiers.</summary>
	/// <param name="riid">Reserved for future use. Must be IID_NULL.</param>
	/// <param name="rgszNames">An array of names to be mapped.</param>
	/// <param name="cNames">The count of the names to be mapped.</param>
	/// <param name="lcid">The locale context in which to interpret the names.</param>
	/// <param name="rgDispId">An array allocated by the caller that receives the identifiers corresponding to the names.</param>
	void GetIDsOfNames([In] ref Guid riid, IntPtr rgszNames, uint cNames, uint lcid, IntPtr rgDispId);

	void GetTypeInfo(uint iTInfo, uint lcid, IntPtr ppTInfo);

	void GetTypeInfoCount(out uint pcTInfo);

	void Invoke(uint dispIdMember, [In] ref Guid riid, uint lcid, short wFlags, IntPtr pDispParams, IntPtr pVarResult, IntPtr pExcepInfo, IntPtr puArgErr);
}
