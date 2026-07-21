using System.Security.Cryptography.Asn1;
using System.Security.Cryptography.Asn1;

namespace System.Security.Cryptography.Pkcs.Asn1
{
	internal struct OtherKeyAttributeAsn
	{
		[ObjectIdentifier]
		internal string KeyAttrId;

		[OptionalValue]
		[AnyValue]
		internal ReadOnlyMemory<byte>? KeyAttr;
	}
}
namespace System.Security.Cryptography.Pkcs.Asn1
{
	internal struct PkiStatusInfo
	{
		public int Status;

		[OptionalValue]
		[AnyValue]
		[ExpectedTag(TagClass.Universal, 16)]
		public ReadOnlyMemory<byte>? StatusString;

		[OptionalValue]
		public PkiFailureInfo? FailInfo;
	}
}
