using System.Security.Cryptography.Asn1;
using System.Security.Cryptography.Asn1;

namespace System.Security.Cryptography.Pkcs.Asn1
{
	internal struct SignerInfoAsn
	{
		public int Version;

		public SignerIdentifierAsn Sid;

		public AlgorithmIdentifierAsn DigestAlgorithm;

		[ExpectedTag(0)]
		[OptionalValue]
		[AnyValue]
		public ReadOnlyMemory<byte>? SignedAttributes;

		public AlgorithmIdentifierAsn SignatureAlgorithm;

		[OctetString]
		public ReadOnlyMemory<byte> SignatureValue;

		[ExpectedTag(1)]
		[SetOf]
		[OptionalValue]
		public AttributeAsn[] UnsignedAttributes;
	}
}
namespace System.Security.Cryptography.Pkcs.Asn1
{
	[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
	internal sealed class EssCertId
	{
		[OctetString]
		public ReadOnlyMemory<byte> Hash;

		[OptionalValue]
		public CadesIssuerSerial? IssuerSerial;
	}
}
