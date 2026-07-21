using System.Runtime.InteropServices;
using System.Security.Cryptography.Asn1;
using System.Security.Cryptography.Asn1;

namespace System.Security.Cryptography.Pkcs.Asn1
{
	[Flags]
	internal enum PkiFailureInfo
	{
		None = 0,
		BadAlg = 1,
		BadMessageCheck = 2,
		BadRequest = 4,
		BadTime = 8,
		BadCertId = 0x10,
		BadDataFormat = 0x20,
		WrongAuthority = 0x40,
		IncorrectData = 0x80,
		MissingTimeStamp = 0x100,
		BadPop = 0x200,
		CertRevoked = 0x400,
		CertConfirmed = 0x800,
		WrongIntegrity = 0x1000,
		BadRecipientNonce = 0x2000,
		TimeNotAvailable = 0x4000,
		UnacceptedPolicy = 0x8000,
		UnacceptedExtension = 0x10000,
		AddInfoNotAvailable = 0x20000,
		BadSenderNonce = 0x40000,
		BadCertTemplate = 0x80000,
		SignerNotTrusted = 0x100000,
		TransactionIdInUse = 0x200000,
		UnsupportedVersion = 0x400000,
		NotAuthorized = 0x800000,
		SystemUnavail = 0x1000000,
		SystemFailure = 0x2000000,
		DuplicateCertReq = 0x4000000
	}
}
namespace System.Security.Cryptography.Pkcs.Asn1
{
	[StructLayout(LayoutKind.Sequential)]
	internal sealed class EssCertIdV2
	{
		[DefaultValue(new byte[]
		{
			48, 11, 6, 9, 96, 134, 72, 1, 101, 3,
			4, 2, 1
		})]
		public AlgorithmIdentifierAsn HashAlgorithm;

		[OctetString]
		public ReadOnlyMemory<byte> Hash;

		[OptionalValue]
		public CadesIssuerSerial? IssuerSerial;
	}
}
namespace System.Security.Cryptography.Pkcs.Asn1
{
	internal struct PssParamsAsn
	{
		[ExpectedTag(0, ExplicitTag = true)]
		[DefaultValue(new byte[]
		{
			160, 9, 48, 7, 6, 5, 43, 14, 3, 2,
			26
		})]
		public AlgorithmIdentifierAsn HashAlgorithm;

		[ExpectedTag(1, ExplicitTag = true)]
		[DefaultValue(new byte[]
		{
			161, 22, 48, 20, 6, 9, 42, 134, 72, 134,
			247, 13, 1, 1, 8, 48, 9, 6, 5, 43,
			14, 3, 2, 26
		})]
		public AlgorithmIdentifierAsn MaskGenAlgorithm;

		[ExpectedTag(2, ExplicitTag = true)]
		[DefaultValue(new byte[] { 162, 3, 2, 1, 20 })]
		public int SaltLength;

		[ExpectedTag(3, ExplicitTag = true)]
		[DefaultValue(new byte[] { 163, 3, 2, 1, 1 })]
		public int TrailerField;
	}
}
