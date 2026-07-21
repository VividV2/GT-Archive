using System.Security.Authentication;
using System.Security.Authentication;

namespace System.Net
{
	internal static class SecurityProtocol
	{
		public const SslProtocols DefaultSecurityProtocols = SslProtocols.Tls | SslProtocols.Tls11 | SslProtocols.Tls12;

		public const SslProtocols SystemDefaultSecurityProtocols = SslProtocols.None;
	}
}
namespace System.Net
{
	internal enum CookieToken
	{
		Nothing,
		NameValuePair,
		Attribute,
		EndToken,
		EndCookie,
		End,
		Equals,
		Comment,
		CommentUrl,
		CookieName,
		Discard,
		Domain,
		Expires,
		MaxAge,
		Path,
		Port,
		Secure,
		HttpOnly,
		Unknown,
		Version
	}
}
