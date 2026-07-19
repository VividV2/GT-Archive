namespace System.Runtime.InteropServices.ComTypes
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("B196B285-BAB4-101A-B69C-00AA00341D07")]
	public interface IEnumConnectionPoints
	{
		[PreserveSig]
		int Next(int celt, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] IConnectionPoint[] rgelt, IntPtr pceltFetched);

		[PreserveSig]
		int Skip(int celt);

		void Reset();

		void Clone(out IEnumConnectionPoints ppenum);
	}
}
namespace System.Runtime.InteropServices
{
	/// <summary>Indicates which <see langword="IDispatch" /> implementation to use for a particular class.</summary>
	[Serializable]
	[ComVisible(true)]
	[Obsolete("The IDispatchImplAttribute is deprecated.", false)]
	public enum IDispatchImplType
	{
		/// <summary>Specifies that the common language runtime decides which <see langword="IDispatch" /> implementation to use.</summary>
		SystemDefinedImpl,
		/// <summary>Specifies that the <see langword="IDispatch" /> implementation is supplied by the runtime.</summary>
		InternalImpl,
		/// <summary>Specifies that the <see langword="IDispatch" /> implementation is supplied by passing the type information for the object to the COM <see langword="CreateStdDispatch" /> API method.</summary>
		CompatibleImpl
	}
}
