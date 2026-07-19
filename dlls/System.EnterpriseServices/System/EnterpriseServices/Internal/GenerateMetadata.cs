using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices;

/// <summary>Represents a structure used in the <see cref="T:System.EnterpriseServices.ITransaction" /> interface.</summary>
/// <summary>Represents a structure used in the <see cref="T:System.EnterpriseServices.ITransaction" /> interface.</summary>
/// <summary>Represents a structure used in the <see cref="T:System.EnterpriseServices.ITransaction" /> interface.</summary>
[ComVisible(false)]
public struct XACTTRANSINFO
{
	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	public int grfRMSupported;

	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	public int grfRMSupportedRetaining;

	/// <summary>Represents a bitmask that indicates which <see langword="grfTC" /> flags this transaction implementation supports.</summary>
	/// <summary>Represents a bitmask that indicates which <see langword="grfTC" /> flags this transaction implementation supports.</summary>
	/// <summary>Represents a bitmask that indicates which <see langword="grfTC" /> flags this transaction implementation supports.</summary>
	public int grfTCSupported;

	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	public int grfTCSupportedRetaining;

	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	public int isoFlags;

	/// <summary>Represents the isolation level associated with this transaction object. ISOLATIONLEVEL_UNSPECIFIED indicates that no isolation level was specified.</summary>
	/// <summary>Represents the isolation level associated with this transaction object. ISOLATIONLEVEL_UNSPECIFIED indicates that no isolation level was specified.</summary>
	/// <summary>Represents the isolation level associated with this transaction object. ISOLATIONLEVEL_UNSPECIFIED indicates that no isolation level was specified.</summary>
	public int isoLevel;

	/// <summary>Represents the unit of work associated with this transaction.</summary>
	/// <summary>Represents the unit of work associated with this transaction.</summary>
	/// <summary>Represents the unit of work associated with this transaction.</summary>
	public BOID uow;
}
namespace System.EnterpriseServices.Internal
{
	/// <summary>Activates SOAP-enabled COM+ application proxies from a client.</summary>
	/// <summary>Activates SOAP-enabled COM+ application proxies from a client.</summary>
	[Guid("ecabafd1-7f19-11d2-978e-0000f8757e2a")]
	public class ClrObjectFactory : IClrObjectFactory
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.EnterpriseServices.Internal.ClrObjectFactory" /> class.</summary>
		/// <summary>Initializes a new instance of the <see cref="T:System.EnterpriseServices.Internal.ClrObjectFactory" /> class.</summary>
		[System.MonoTODO]
		public ClrObjectFactory()
		{
			throw new NotImplementedException();
		}

		/// <summary>Activates a remote assembly through .NET remoting, using the assembly's configuration file.</summary>
		/// <param name="AssemblyName">The name of the assembly to activate.</param>
		/// <param name="TypeName">The name of the type to activate.</param>
		/// <param name="Mode">Not used.</param>
		/// <returns>An instance of the <see cref="T:System.Object" /> that represents the type, with culture, arguments, and binding and activation attributes set to <see langword="null" />, or <see langword="null" /> if the <paramref name="TypeName" /> parameter is not found.</returns>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call chain does not have permission to access unmanaged code.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">The class is not registered.</exception>
		/// <summary>Activates a remote assembly through .NET remoting, using the assembly's configuration file.</summary>
		/// <param name="AssemblyName">The name of the assembly to activate.</param>
		/// <param name="TypeName">The name of the type to activate.</param>
		/// <param name="Mode">Not used.</param>
		/// <returns>An instance of the <see cref="T:System.Object" /> that represents the type, with culture, arguments, and binding and activation attributes set to <see langword="null" />, or <see langword="null" /> if the <paramref name="TypeName" /> parameter is not found.</returns>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call chain does not have permission to access unmanaged code.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">The class is not registered.</exception>
		[System.MonoTODO]
		public object CreateFromAssembly(string AssemblyName, string TypeName, string Mode)
		{
			throw new NotImplementedException();
		}

		/// <summary>Activates a remote assembly through .NET remoting, using the remote assembly's mailbox. Currently not implemented; throws a <see cref="T:System.Runtime.InteropServices.COMException" /> if called.</summary>
		/// <param name="Mailbox">A mailbox on the Web service.</param>
		/// <param name="Mode">Not used.</param>
		/// <returns>This method throws an exception if called.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Simple Mail Transfer Protocol (SMTP) is not implemented.</exception>
		/// <summary>Activates a remote assembly through .NET remoting, using the remote assembly's mailbox. Currently not implemented; throws a <see cref="T:System.Runtime.InteropServices.COMException" /> if called.</summary>
		/// <param name="Mailbox">A mailbox on the Web service.</param>
		/// <param name="Mode">Not used.</param>
		/// <returns>This method throws an exception if called.</returns>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">Simple Mail Transfer Protocol (SMTP) is not implemented.</exception>
		[System.MonoTODO]
		public object CreateFromMailbox(string Mailbox, string Mode)
		{
			throw new NotImplementedException();
		}

		/// <summary>Activates a remote assembly through .NET remoting, using the virtual root URL of the remote assembly.</summary>
		/// <param name="VrootUrl">The virtual root URL of the object to be activated.</param>
		/// <param name="Mode">Not used.</param>
		/// <returns>An instance of the <see cref="T:System.Object" /> representing the type, with culture, arguments, and binding and activation attributes set to <see langword="null" />, or <see langword="null" /> if the assembly identified by the <paramref name="VrootUrl" /> parameter is not found.</returns>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call chain does not have permission to access unmanaged code.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">The thread token could not be opened.</exception>
		/// <summary>Activates a remote assembly through .NET remoting, using the virtual root URL of the remote assembly.</summary>
		/// <param name="VrootUrl">The virtual root URL of the object to be activated.</param>
		/// <param name="Mode">Not used.</param>
		/// <returns>An instance of the <see cref="T:System.Object" /> representing the type, with culture, arguments, and binding and activation attributes set to <see langword="null" />, or <see langword="null" /> if the assembly identified by the <paramref name="VrootUrl" /> parameter is not found.</returns>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call chain does not have permission to access unmanaged code.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">The thread token could not be opened.</exception>
		[System.MonoTODO]
		public object CreateFromVroot(string VrootUrl, string Mode)
		{
			throw new NotImplementedException();
		}

		/// <summary>Activates a remote assembly through .NET remoting, using the Web Services Description Language (WSDL) of the XML Web service.</summary>
		/// <param name="WsdlUrl">The WSDL URL of the Web service.</param>
		/// <param name="Mode">Not used.</param>
		/// <returns>An instance of the <see cref="T:System.Object" /> representing the type, with culture, arguments, and binding and activation attributes set to <see langword="null" />, or <see langword="null" /> if the assembly identified by the <paramref name="WsdlUrl" /> parameter is not found.</returns>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call chain does not have permission to access unmanaged code.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">The thread token could not be opened.</exception>
		/// <summary>Activates a remote assembly through .NET remoting, using the Web Services Description Language (WSDL) of the XML Web service.</summary>
		/// <param name="WsdlUrl">The WSDL URL of the Web service.</param>
		/// <param name="Mode">Not used.</param>
		/// <returns>An instance of the <see cref="T:System.Object" /> representing the type, with culture, arguments, and binding and activation attributes set to <see langword="null" />, or <see langword="null" /> if the assembly identified by the <paramref name="WsdlUrl" /> parameter is not found.</returns>
		/// <exception cref="T:System.Security.SecurityException">A caller in the call chain does not have permission to access unmanaged code.</exception>
		/// <exception cref="T:System.Runtime.InteropServices.COMException">The thread token could not be opened.</exception>
		[System.MonoTODO]
		public object CreateFromWsdl(string WsdlUrl, string Mode)
		{
			throw new NotImplementedException();
		}
	}
}
namespace System.EnterpriseServices.Internal
{
	/// <summary>Generates common language runtime (CLR) metadata for a COM+ component.</summary>
	[Guid("d8013ff1-730b-45e2-ba24-874b7242c425")]
	public class GenerateMetadata : IComSoapMetadata
	{
		/// <summary>Initializes a new instance of the <see cref="T:System.EnterpriseServices.Internal.GenerateMetadata" /> class.</summary>
		[System.MonoTODO]
		public GenerateMetadata()
		{
			throw new NotImplementedException();
		}

		/// <summary>Generates, or locates, an assembly that contains common language runtime (CLR) metadata for a COM+ component represented by the specified type library.</summary>
		/// <param name="strSrcTypeLib">The name of the type library for which to generate an assembly.</param>
		/// <param name="outPath">The folder in which to generate an assembly or to locate an already existing assembly.</param>
		/// <returns>The generated assembly name; otherwise, an empty string if the inputs are invalid.</returns>
		[System.MonoTODO]
		public string Generate(string strSrcTypeLib, string outPath)
		{
			throw new NotImplementedException();
		}

		/// <summary>Generates, or locates, an assembly that contains common language runtime (CLR) metadata for a COM+ component represented by the specified type library, signs the assembly with a strong-named key pair, and installs it in the global assembly cache.</summary>
		/// <param name="strSrcTypeLib">The name of the type library for which to generate an assembly.</param>
		/// <param name="outPath">The folder in which to generate an assembly or to locate an already existing assembly.</param>
		/// <param name="PublicKey">A public key used to import type library information into an assembly.</param>
		/// <param name="KeyPair">A strong-named key pair used to sign the generated assembly.</param>
		/// <returns>The generated assembly name; otherwise, an empty string if the inputs are invalid.</returns>
		[System.MonoTODO]
		public string GenerateMetaData(string strSrcTypeLib, string outPath, byte[] PublicKey, StrongNameKeyPair KeyPair)
		{
			throw new NotImplementedException();
		}

		/// <summary>Generates, or locates, an assembly that contains common language runtime (CLR) metadata for a COM+ component represented by the specified type library, signs the assembly with a strong-named key pair, and installs it in the global assembly cache.</summary>
		/// <param name="strSrcTypeLib">The name of the type library for which to generate an assembly.</param>
		/// <param name="outPath">The folder in which to generate an assembly or to locate an already existing assembly.</param>
		/// <param name="InstallGac">Ignored.</param>
		/// <param name="Error">A string to which an error message can be written.</param>
		/// <returns>The generated assembly name; otherwise, an empty string if the inputs are invalid.</returns>
		[System.MonoTODO]
		public string GenerateSigned(string strSrcTypeLib, string outPath, bool InstallGac, out string Error)
		{
			throw new NotImplementedException();
		}

		/// <summary>Searches for a specified file in a specified path.</summary>
		/// <param name="path">The path to be searched for the file.</param>
		/// <param name="fileName">The name of the file for which to search.</param>
		/// <param name="extension">An extension to be added to the file name when searching for the file.</param>
		/// <param name="numBufferChars">The size of the buffer that receives the valid path and file name.</param>
		/// <param name="buffer">The buffer that receives the path and file name of the file found.</param>
		/// <param name="filePart">The variable that receives the address of the last component of the valid path and file name.</param>
		/// <returns>If the search succeeds, the return value is the length of the string copied to <paramref name="buffer" />. If the search fails, the return value is 0.</returns>
		[System.MonoTODO]
		public static int SearchPath(string path, string fileName, string extension, int numBufferChars, string buffer, int[] filePart)
		{
			throw new NotImplementedException();
		}
	}
}
