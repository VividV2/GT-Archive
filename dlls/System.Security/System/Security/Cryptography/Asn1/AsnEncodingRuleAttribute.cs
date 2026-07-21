namespace System.Security.Cryptography.Pkcs.Asn1
{
	internal struct SigningCertificateAsn
	{
		public EssCertId[] Certs;

		[OptionalValue]
		public PolicyInformation[] Policies;
	}
}
namespace System.Security.Cryptography.Pkcs
{
}
