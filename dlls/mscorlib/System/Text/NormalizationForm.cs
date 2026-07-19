namespace System.Security
{
	/// <summary>Defines the methods that convert permission object state to and from XML element representation.</summary>
	public interface ISecurityEncodable
	{
		/// <summary>Reconstructs a security object with a specified state from an XML encoding.</summary>
		/// <param name="e">The XML encoding to use to reconstruct the security object.</param>
		void FromXml(SecurityElement e);

		/// <summary>Creates an XML encoding of the security object and its current state.</summary>
		/// <returns>An XML encoding of the security object, including any state information.</returns>
		SecurityElement ToXml();
	}
}
namespace System.Text
{
	/// <summary>Defines the type of normalization to perform.</summary>
	public enum NormalizationForm
	{
		/// <summary>Indicates that a Unicode string is normalized using full canonical decomposition, followed by the replacement of sequences with their primary composites, if possible.</summary>
		FormC = 1,
		/// <summary>Indicates that a Unicode string is normalized using full canonical decomposition.</summary>
		FormD = 2,
		/// <summary>Indicates that a Unicode string is normalized using full compatibility decomposition, followed by the replacement of sequences with their primary composites, if possible.</summary>
		FormKC = 5,
		/// <summary>Indicates that a Unicode string is normalized using full compatibility decomposition.</summary>
		FormKD = 6
	}
}
