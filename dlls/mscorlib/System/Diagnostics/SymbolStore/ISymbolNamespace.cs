using System.Runtime.InteropServices;

namespace System.Diagnostics.Contracts;

/// <summary>Specifies the type of contract that failed.</summary>
/// <summary>Specifies the type of contract that failed.</summary>
public enum ContractFailureKind
{
	/// <summary>A <see cref="Overload:System.Diagnostics.Contracts.Contract.Requires" /> contract failed.</summary>
	/// <summary>A <see cref="Overload:System.Diagnostics.Contracts.Contract.Requires" /> contract failed.</summary>
	Precondition,
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Ensures" /> contract failed.</summary>
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Ensures" /> contract failed.</summary>
	Postcondition,
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.EnsuresOnThrow" /> contract failed.</summary>
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.EnsuresOnThrow" /> contract failed.</summary>
	PostconditionOnException,
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Invariant" /> contract failed.</summary>
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Invariant" /> contract failed.</summary>
	Invariant,
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Assert" /> contract failed.</summary>
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Assert" /> contract failed.</summary>
	Assert,
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Assume" /> contract failed.</summary>
	/// <summary>An <see cref="Overload:System.Diagnostics.Contracts.Contract.Assume" /> contract failed.</summary>
	Assume
}
namespace System.Diagnostics.SymbolStore
{
	/// <summary>Represents a namespace within a symbol store.</summary>
	[ComVisible(true)]
	public interface ISymbolNamespace
	{
		/// <summary>Gets the current namespace.</summary>
		/// <returns>The current namespace.</returns>
		string Name { get; }

		/// <summary>Gets the child members of the current namespace.</summary>
		/// <returns>The child members of the current namespace.</returns>
		ISymbolNamespace[] GetNamespaces();

		/// <summary>Gets all the variables defined at global scope within the current namespace.</summary>
		/// <returns>The variables defined at global scope within the current namespace.</returns>
		ISymbolVariable[] GetVariables();
	}
}
