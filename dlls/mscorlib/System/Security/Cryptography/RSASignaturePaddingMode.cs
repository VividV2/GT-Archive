using System.Runtime.InteropServices;

namespace System.Security.Cryptography
{
}
namespace System.Security.Cryptography
{
	/// <summary>Specifies flags that modify the behavior of the cryptographic service providers (CSP).</summary>
	/// <summary>Specifies flags that modify the behavior of the cryptographic service providers (CSP).</summary>
	[Serializable]
	[Flags]
	[ComVisible(true)]
	public enum CspProviderFlags
	{
		/// <summary>Do not specify any settings.</summary>
		/// <summary>Do not specify any settings.</summary>
		NoFlags = 0,
		/// <summary>Use key information from the computer's key store.</summary>
		/// <summary>Use key information from the computer's key store.</summary>
		UseMachineKeyStore = 1,
		/// <summary>Use key information from the default key container.</summary>
		/// <summary>Use key information from the default key container.</summary>
		UseDefaultKeyContainer = 2,
		/// <summary>Use key information that cannot be exported.</summary>
		/// <summary>Use key information that cannot be exported.</summary>
		UseNonExportableKey = 4,
		/// <summary>Use key information from the current key.</summary>
		/// <summary>Use key information from the current key.</summary>
		UseExistingKey = 8,
		/// <summary>Allow a key to be exported for archival or recovery.</summary>
		/// <summary>Allow a key to be exported for archival or recovery.</summary>
		UseArchivableKey = 0x10,
		/// <summary>Notify the user through a dialog box or another method when certain actions are attempting to use a key.  This flag is not compatible with the <see cref="F:System.Security.Cryptography.CspProviderFlags.NoPrompt" /> flag.</summary>
		/// <summary>Notify the user through a dialog box or another method when certain actions are attempting to use a key.  This flag is not compatible with the <see cref="F:System.Security.Cryptography.CspProviderFlags.NoPrompt" /> flag.</summary>
		UseUserProtectedKey = 0x20,
		/// <summary>Prevent the CSP from displaying any user interface (UI) for this context.</summary>
		/// <summary>Prevent the CSP from displaying any user interface (UI) for this context.</summary>
		NoPrompt = 0x40,
		/// <summary>Create a temporary key that is released when the associated Rivest-Shamir-Adleman (RSA) object is closed. Do not use this flag if you want your key to be independent of the RSA object.</summary>
		/// <summary>Create a temporary key that is released when the associated Rivest-Shamir-Adleman (RSA) object is closed. Do not use this flag if you want your key to be independent of the RSA object.</summary>
		CreateEphemeralKey = 0x80
	}
}
namespace System.Security.Cryptography
{
	/// <summary>Specifies the padding mode to use with RSA signature creation or verification operations.</summary>
	/// <summary>Specifies the padding mode to use with RSA signature creation or verification operations.</summary>
	public enum RSASignaturePaddingMode
	{
		/// <summary>PKCS #1 v1.5</summary>
		/// <summary>PKCS #1 v1.5</summary>
		Pkcs1,
		/// <summary>Probabilistic Signature Scheme</summary>
		/// <summary>Probabilistic Signature Scheme</summary>
		Pss
	}
}
