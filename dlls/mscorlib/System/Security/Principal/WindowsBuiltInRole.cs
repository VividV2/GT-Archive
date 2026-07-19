using System.Runtime.InteropServices;

namespace System.Runtime.InteropServices
{
	[ComImport]
	[Guid("00020401-0000-0000-C000-000000000046")]
	[Obsolete("Use System.Runtime.InteropServices.ComTypes.ITypeInfo instead. http://go.microsoft.com/fwlink/?linkid=14202", false)]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	public interface UCOMITypeInfo
	{
		void GetTypeAttr(out IntPtr ppTypeAttr);

		void GetTypeComp(out UCOMITypeComp ppTComp);

		void GetFuncDesc(int index, out IntPtr ppFuncDesc);

		void GetVarDesc(int index, out IntPtr ppVarDesc);

		void GetNames(int memid, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 2)] string[] rgBstrNames, int cMaxNames, out int pcNames);

		void GetRefTypeOfImplType(int index, out int href);

		void GetImplTypeFlags(int index, out int pImplTypeFlags);

		void GetIDsOfNames([In][MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] string[] rgszNames, int cNames, [Out][MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 1)] int[] pMemId);

		void Invoke([MarshalAs(UnmanagedType.IUnknown)] object pvInstance, int memid, short wFlags, ref DISPPARAMS pDispParams, out object pVarResult, out EXCEPINFO pExcepInfo, out int puArgErr);

		void GetDocumentation(int index, out string strName, out string strDocString, out int dwHelpContext, out string strHelpFile);

		void GetDllEntry(int memid, INVOKEKIND invKind, out string pBstrDllName, out string pBstrName, out short pwOrdinal);

		void GetRefTypeInfo(int hRef, out UCOMITypeInfo ppTI);

		void AddressOfMember(int memid, INVOKEKIND invKind, out IntPtr ppv);

		void CreateInstance([MarshalAs(UnmanagedType.IUnknown)] object pUnkOuter, ref Guid riid, [MarshalAs(UnmanagedType.IUnknown)] out object ppvObj);

		void GetMops(int memid, out string pBstrMops);

		void GetContainingTypeLib(out UCOMITypeLib ppTLB, out int pIndex);

		void ReleaseTypeAttr(IntPtr pTypeAttr);

		void ReleaseFuncDesc(IntPtr pFuncDesc);

		void ReleaseVarDesc(IntPtr pVarDesc);
	}
}
namespace System.Security.Principal
{
	/// <summary>Specifies common roles to be used with <see cref="M:System.Security.Principal.WindowsPrincipal.IsInRole(System.String)" />.</summary>
	[Serializable]
	[ComVisible(true)]
	public enum WindowsBuiltInRole
	{
		/// <summary>Administrators have complete and unrestricted access to the computer or domain.</summary>
		Administrator = 544,
		/// <summary>Users are prevented from making accidental or intentional system-wide changes. Thus, users can run certified applications, but not most legacy applications.</summary>
		User,
		/// <summary>Guests are more restricted than users.</summary>
		Guest,
		/// <summary>Power users possess most administrative permissions with some restrictions. Thus, power users can run legacy applications, in addition to certified applications.</summary>
		PowerUser,
		/// <summary>Account operators manage the user accounts on a computer or domain.</summary>
		AccountOperator,
		/// <summary>System operators manage a particular computer.</summary>
		SystemOperator,
		/// <summary>Print operators can take control of a printer.</summary>
		PrintOperator,
		/// <summary>Backup operators can override security restrictions for the sole purpose of backing up or restoring files.</summary>
		BackupOperator,
		/// <summary>Replicators support file replication in a domain.</summary>
		Replicator
	}
}
namespace System
{
}
