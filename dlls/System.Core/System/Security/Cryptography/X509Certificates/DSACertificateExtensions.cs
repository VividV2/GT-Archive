namespace System;

/// <summary>Encapsulates a method that has 13 parameters and does not return a value.</summary>
/// <param name="arg1">The first parameter of the method that this delegate encapsulates.</param>
/// <param name="arg2">The second parameter of the method that this delegate encapsulates.</param>
/// <param name="arg3">The third parameter of the method that this delegate encapsulates.</param>
/// <param name="arg4">The fourth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg5">The fifth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg6">The sixth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg7">The seventh parameter of the method that this delegate encapsulates.</param>
/// <param name="arg8">The eighth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg9">The ninth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg10">The tenth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg11">The eleventh parameter of the method that this delegate encapsulates.</param>
/// <param name="arg12">The twelfth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg13">The thirteenth parameter of the method that this delegate encapsulates.</param>
/// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
/// <summary>Encapsulates a method that has 13 parameters and does not return a value.</summary>
/// <param name="arg1">The first parameter of the method that this delegate encapsulates.</param>
/// <param name="arg2">The second parameter of the method that this delegate encapsulates.</param>
/// <param name="arg3">The third parameter of the method that this delegate encapsulates.</param>
/// <param name="arg4">The fourth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg5">The fifth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg6">The sixth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg7">The seventh parameter of the method that this delegate encapsulates.</param>
/// <param name="arg8">The eighth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg9">The ninth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg10">The tenth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg11">The eleventh parameter of the method that this delegate encapsulates.</param>
/// <param name="arg12">The twelfth parameter of the method that this delegate encapsulates.</param>
/// <param name="arg13">The thirteenth parameter of the method that this delegate encapsulates.</param>
/// <typeparam name="T1">The type of the first parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T2">The type of the second parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T3">The type of the third parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T4">The type of the fourth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T5">The type of the fifth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T6">The type of the sixth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T7">The type of the seventh parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T8">The type of the eighth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T9">The type of the ninth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T10">The type of the tenth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T11">The type of the eleventh parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T12">The type of the twelfth parameter of the method that this delegate encapsulates.</typeparam>
/// <typeparam name="T13">The type of the thirteenth parameter of the method that this delegate encapsulates.</typeparam>
public delegate void Action<in T1, in T2, in T3, in T4, in T5, in T6, in T7, in T8, in T9, in T10, in T11, in T12, in T13>(T1 arg1, T2 arg2, T3 arg3, T4 arg4, T5 arg5, T6 arg6, T7 arg7, T8 arg8, T9 arg9, T10 arg10, T11 arg11, T12 arg12, T13 arg13);
namespace System.Security.Cryptography.X509Certificates
{
	/// <summary>Provides extension methods for retrieving <see cref="T:System.Security.Cryptography.DSA" /> implementations for the public and private keys of an <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />. </summary>
	public static class DSACertificateExtensions
	{
		/// <summary>Gets the <see cref="T:System.Security.Cryptography.DSA" /> public key from the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
		/// <param name="certificate">The certificate. </param>
		/// <returns>The public key, or <see langword="null" /> if the certificate does not have a DSA public key. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="certificate" /> is <see langword="null" />. </exception>
		/// <exception cref="T:System.Security.Cryptography.CryptographicException">Windows reports an error. See the <see cref="P:System.Exception.Message" /> property for more information. </exception>
		public static DSA GetDSAPublicKey(this X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			return certificate.PrivateKey as DSA;
		}

		/// <summary>Gets the <see cref="T:System.Security.Cryptography.DSA" /> private key from the <see cref="T:System.Security.Cryptography.X509Certificates.X509Certificate2" />.</summary>
		/// <param name="certificate">The certificate. </param>
		/// <returns>The private key, or <see langword="null" /> if the certificate does not have a DSA private key. </returns>
		/// <exception cref="T:System.ArgumentNullException">
		///         <paramref name="certificate" /> is <see langword="null" />. </exception>
		public static DSA GetDSAPrivateKey(this X509Certificate2 certificate)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			return certificate.PublicKey.Key as DSA;
		}

		/// <summary>Combines a private key with the public key of a <see cref="T:System.Security.Cryptography.DSA" /> certificate to generate a new DSA certificate.</summary>
		/// <param name="certificate">The DSA certificate.</param>
		/// <param name="privateKey">The private DSA key.</param>
		/// <returns>A new DSA certificate with the <see cref="P:System.Security.Cryptography.X509Certificates.X509Certificate2.HasPrivateKey" /> property set to <see langword="true" />. The input DSA certificate object isn't modified.</returns>
		/// <exception cref="T:System.ArgumentNullException">
		///   <paramref name="certificate" /> or <paramref name="privateKey" /> is <see langword="null" />.</exception>
		/// <exception cref="T:System.InvalidOperationException">The certificate already has an associated private key.</exception>
		/// <exception cref="T:System.ArgumentException">The certificate doesn't have a public key.-or-The specified private key doesn't match the public key for the specified certificate.</exception>
		[MonoTODO]
		public static X509Certificate2 CopyWithPrivateKey(this X509Certificate2 certificate, DSA privateKey)
		{
			if (certificate == null)
			{
				throw new ArgumentNullException("certificate");
			}
			if (privateKey == null)
			{
				throw new ArgumentNullException("privateKey");
			}
			throw new NotImplementedException();
		}
	}
}
