namespace System
{
	/// <summary>Defines a generalized method that a value type or class implements to create a type-specific method for determining equality of instances.</summary>
	/// <typeparam name="T">The type of objects to compare.</typeparam>
	/// <summary>Defines a generalized method that a value type or class implements to create a type-specific method for determining equality of instances.</summary>
	/// <typeparam name="T">The type of objects to compare.</typeparam>
	/// <summary>Defines a generalized method that a value type or class implements to create a type-specific method for determining equality of instances.</summary>
	/// <typeparam name="T">The type of objects to compare.</typeparam>
	public interface IEquatable<T>
	{
		/// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
		/// <param name="other">An object to compare with this object.</param>
		/// <returns>
		///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
		/// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
		/// <param name="other">An object to compare with this object.</param>
		/// <returns>
		///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
		/// <summary>Indicates whether the current object is equal to another object of the same type.</summary>
		/// <param name="other">An object to compare with this object.</param>
		/// <returns>
		///   <see langword="true" /> if the current object is equal to the <paramref name="other" /> parameter; otherwise, <see langword="false" />.</returns>
		bool Equals(T other);
	}
}
namespace System.Security
{
	/// <summary>Specifies the default partial-trust visibility for code that is marked with the <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> (APTCA) attribute.</summary>
	/// <summary>Specifies the default partial-trust visibility for code that is marked with the <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> (APTCA) attribute.</summary>
	/// <summary>Specifies the default partial-trust visibility for code that is marked with the <see cref="T:System.Security.AllowPartiallyTrustedCallersAttribute" /> (APTCA) attribute.</summary>
	public enum PartialTrustVisibilityLevel
	{
		/// <summary>The assembly can always be called by partial-trust code.</summary>
		/// <summary>The assembly can always be called by partial-trust code.</summary>
		/// <summary>The assembly can always be called by partial-trust code.</summary>
		VisibleToAllHosts,
		/// <summary>The assembly has been audited for partial trust, but it is not visible to partial-trust code in all hosts. To make the assembly visible to partial-trust code, add it to the <see cref="P:System.AppDomainSetup.PartialTrustVisibleAssemblies" /> property.</summary>
		/// <summary>The assembly has been audited for partial trust, but it is not visible to partial-trust code in all hosts. To make the assembly visible to partial-trust code, add it to the <see cref="P:System.AppDomainSetup.PartialTrustVisibleAssemblies" /> property.</summary>
		/// <summary>The assembly has been audited for partial trust, but it is not visible to partial-trust code in all hosts. To make the assembly visible to partial-trust code, add it to the <see cref="P:System.AppDomainSetup.PartialTrustVisibleAssemblies" /> property.</summary>
		NotVisibleByDefault
	}
}
