using System.Security.Cryptography.Asn1;

namespace System.Security.Cryptography.Pkcs.Asn1
{
	internal struct ContentInfoAsn
	{
		[ObjectIdentifier]
		public string ContentType;

		[AnyValue]
		[ExpectedTag(0, ExplicitTag = true)]
		public ReadOnlyMemory<byte> Content;
	}
}
namespace System.Security.Cryptography.Pkcs
{
}
namespace System.Security.Cryptography.Pkcs
{
}
namespace System.Security.Cryptography.Pkcs
{
}
