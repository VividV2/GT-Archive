using System;
using System;

namespace Mono.Security.Interface
{
	[Flags]
	public enum MonoSslPolicyErrors
	{
		None = 0,
		RemoteCertificateNotAvailable = 1,
		RemoteCertificateNameMismatch = 2,
		RemoteCertificateChainErrors = 4
	}
}
namespace Mono.Security.Interface
{
	internal interface IMonoSslClientAuthenticationOptions : IMonoAuthenticationOptions
	{
		System.Net.Security.LocalCertificateSelectionCallback LocalCertificateSelectionCallback { get; set; }

		string TargetHost { get; set; }

		System.Security.Cryptography.X509Certificates.X509CertificateCollection ClientCertificates { get; set; }
	}
}
