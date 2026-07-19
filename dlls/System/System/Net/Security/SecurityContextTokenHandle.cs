namespace System.Net.Security;

/// <summary>Enumerates Secure Socket Layer (SSL) policy errors.</summary>
[Flags]
public enum SslPolicyErrors
{
	/// <summary>No SSL policy errors.</summary>
	None = 0,
	/// <summary>Certificate not available.</summary>
	RemoteCertificateNotAvailable = 1,
	RemoteCertificateNameMismatch = 2,
	RemoteCertificateChainErrors = 4
}
namespace System.Net
{
}
