using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography.X509Certificates;

namespace Mono.Security.Interface
{
	public interface ICertificateValidator
	{
		MonoTlsSettings Settings { get; }

		bool SelectClientCertificate(string targetHost, X509CertificateCollection localCertificates, X509Certificate remoteCertificate, string[] acceptableIssuers, out X509Certificate clientCertificate);

		ValidationResult ValidateCertificate(string targetHost, bool serverMode, X509CertificateCollection certificates);
	}
}
namespace Mono.Security.Interface
{
	public enum CipherAlgorithmType
	{
		None,
		Aes128,
		Aes256,
		AesGcm128,
		AesGcm256
	}
}
