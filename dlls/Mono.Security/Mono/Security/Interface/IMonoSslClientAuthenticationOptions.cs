using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Security.Interface
{
	internal interface IMonoSslClientAuthenticationOptions : IMonoAuthenticationOptions
	{
		LocalCertificateSelectionCallback LocalCertificateSelectionCallback { get; set; }

		string TargetHost { get; set; }

		X509CertificateCollection ClientCertificates { get; set; }
	}
}
namespace Mono.Security.Interface
{
	public enum MonoEncryptionPolicy
	{
		RequireEncryption,
		AllowNoEncryption,
		NoEncryption
	}
}
