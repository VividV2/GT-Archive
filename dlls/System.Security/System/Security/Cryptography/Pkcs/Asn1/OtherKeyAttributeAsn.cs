namespace System.Security.Cryptography.Pkcs.Asn1
{
	internal enum PkiStatus
	{
		Granted,
		GrantedWithMods,
		Rejection,
		Waiting,
		RevocationWarning,
		RevocationNotification,
		KeyUpdateWarning
	}
}
namespace System.Security.Cryptography.Pkcs.Asn1
{
	internal struct EnvelopedDataAsn
	{
		public int Version;

		[OptionalValue]
		[ExpectedTag(0)]
		public OriginatorInfoAsn OriginatorInfo;

		[SetOf]
		public RecipientInfoAsn[] RecipientInfos;

		public EncryptedContentInfoAsn EncryptedContentInfo;

		[OptionalValue]
		[ExpectedTag(1)]
		[SetOf]
		public AttributeAsn[] UnprotectedAttributes;
	}
}
