using System.Net;
using System.Security.Cryptography.X509Certificates;
using Mono.Security.Interface;

namespace Mono.Net.Security
{
	internal delegate bool ServerCertValidationCallbackWrapper(ServerCertValidationCallback callback, X509Certificate certificate, X509Chain chain, MonoSslPolicyErrors sslPolicyErrors);
}
namespace System.IO.Ports
{
	public delegate void SerialPinChangedEventHandler(object sender, SerialPinChangedEventArgs e);
}
namespace System.Configuration
{
}
