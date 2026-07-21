namespace System.Net.NetworkInformation
{
	/// <summary>Specifies the Internet Protocol versions that are supported by a network interface.</summary>
	/// <summary>Specifies the Internet Protocol versions that are supported by a network interface.</summary>
	public enum NetworkInterfaceComponent
	{
		/// <summary>Internet Protocol version 4.</summary>
		/// <summary>Internet Protocol version 4.</summary>
		IPv4,
		/// <summary>Internet Protocol version 6.</summary>
		/// <summary>Internet Protocol version 6.</summary>
		IPv6
	}
}
namespace System.Net
{
	/// <summary>Specifies the security protocols that are supported by the Schannel security package.</summary>
	/// <summary>Specifies the security protocols that are supported by the Schannel security package.</summary>
	[Flags]
	public enum SecurityProtocolType
	{
		/// <summary>Allows the operating system to choose the best protocol to use, and to block protocols that are not secure. Unless your app has a specific reason not to, you should use this value.</summary>
		/// <summary>Allows the operating system to choose the best protocol to use, and to block protocols that are not secure. Unless your app has a specific reason not to, you should use this value.</summary>
		SystemDefault = 0,
		/// <summary>Specifies the Secure Socket Layer (SSL) 3.0 security protocol. SSL 3.0 has been superseded by the Transport Layer Security (TLS) protocol and is provided for backward compatibility only.</summary>
		/// <summary>Specifies the Secure Socket Layer (SSL) 3.0 security protocol. SSL 3.0 has been superseded by the Transport Layer Security (TLS) protocol and is provided for backward compatibility only.</summary>
		Ssl3 = 0x30,
		/// <summary>Specifies the Transport Layer Security (TLS) 1.0 security protocol. The TLS 1.0 protocol is defined in IETF RFC 2246.</summary>
		/// <summary>Specifies the Transport Layer Security (TLS) 1.0 security protocol. The TLS 1.0 protocol is defined in IETF RFC 2246.</summary>
		Tls = 0xC0,
		/// <summary>Specifies the Transport Layer Security (TLS) 1.1 security protocol. The TLS 1.1 protocol is defined in IETF RFC 4346. On Windows systems, this value is supported starting with Windows 7.</summary>
		/// <summary>Specifies the Transport Layer Security (TLS) 1.1 security protocol. The TLS 1.1 protocol is defined in IETF RFC 4346. On Windows systems, this value is supported starting with Windows 7.</summary>
		Tls11 = 0x300,
		/// <summary>Specifies the Transport Layer Security (TLS) 1.2 security protocol. The TLS 1.2 protocol is defined in IETF RFC 5246. On Windows systems, this value is supported starting with Windows 7.</summary>
		/// <summary>Specifies the Transport Layer Security (TLS) 1.2 security protocol. The TLS 1.2 protocol is defined in IETF RFC 5246. On Windows systems, this value is supported starting with Windows 7.</summary>
		Tls12 = 0xC00,
		/// <summary>Specifies the TLS 1.3 security protocol. The TLS protocol is defined in IETF RFC 8446.</summary>
		/// <summary>Specifies the TLS 1.3 security protocol. The TLS protocol is defined in IETF RFC 8446.</summary>
		Tls13 = 0x3000
	}
}
namespace System.IO
{
}
namespace System.Collections.Specialized
{
}
namespace System.Net.NetworkInformation
{
	/// <summary>References one or more methods to be called when the availability of the network changes.</summary>
	/// <param name="sender">The source of the event.</param>
	/// <param name="e">An <see cref="T:System.EventArgs" /> object that contains data about the event.</param>
	public delegate void NetworkAvailabilityChangedEventHandler(object sender, NetworkAvailabilityEventArgs e);
}
