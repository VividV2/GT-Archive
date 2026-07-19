using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices;

namespace System.EnterpriseServices;

/// <summary>Represents a structure used in the <see cref="T:System.EnterpriseServices.ITransaction" /> interface.</summary>
/// <summary>Represents a structure used in the <see cref="T:System.EnterpriseServices.ITransaction" /> interface.</summary>
[ComVisible(false)]
public struct XACTTRANSINFO
{
	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	public int grfRMSupported;

	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	public int grfRMSupportedRetaining;

	/// <summary>Represents a bitmask that indicates which <see langword="grfTC" /> flags this transaction implementation supports.</summary>
	/// <summary>Represents a bitmask that indicates which <see langword="grfTC" /> flags this transaction implementation supports.</summary>
	public int grfTCSupported;

	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	public int grfTCSupportedRetaining;

	/// <summary>Specifies zero. This field is reserved.</summary>
	/// <summary>Specifies zero. This field is reserved.</summary>
	public int isoFlags;

	/// <summary>Represents the isolation level associated with this transaction object. ISOLATIONLEVEL_UNSPECIFIED indicates that no isolation level was specified.</summary>
	/// <summary>Represents the isolation level associated with this transaction object. ISOLATIONLEVEL_UNSPECIFIED indicates that no isolation level was specified.</summary>
	public int isoLevel;

	/// <summary>Represents the unit of work associated with this transaction.</summary>
	/// <summary>Represents the unit of work associated with this transaction.</summary>
	public BOID uow;
}
namespace System.EnterpriseServices.Internal
{
	/// <summary>Activates SOAP-enabled COM+ application proxies from a client.</summary>
	[Guid("ecabafd1-7f19-11d2-978e-0000f8757e2a")]
	public class ClrObjectFactory : IClrObjectFactory
	{
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
		[System.MonoTODO]
		public object CreateFromWsdl(string WsdlUrl, string Mode)
		{
			throw new NotImplementedException();
		}
	}
}
namespace System.EnterpriseServices.Internal
{
}
