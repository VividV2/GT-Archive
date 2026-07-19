using System.Security.Cryptography.X509Certificates;

namespace System.ComponentModel
{
}
namespace System.Net.Security
{
	internal delegate bool RemoteCertValidationCallback(string host, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors);
}
