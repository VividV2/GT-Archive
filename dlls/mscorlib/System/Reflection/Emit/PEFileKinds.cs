using System.Runtime.InteropServices;

namespace System.Diagnostics.SymbolStore;

/// <summary>Represents a method within a symbol store.</summary>
[ComVisible(true)]
public interface ISymbolMethod
{
	/// <summary>Gets the root lexical scope for the current method. This scope encloses the entire method.</summary>
	/// <returns>The root lexical scope that encloses the entire method.</returns>
	ISymbolScope RootScope { get; }

	/// <summary>Gets a count of the sequence points in the method.</summary>
	/// <returns>The count of the sequence points in the method.</returns>
	int SequencePointCount { get; }

	/// <summary>Gets the <see cref="T:System.Diagnostics.SymbolStore.SymbolToken" /> containing the metadata for the current method.</summary>
	/// <returns>The metadata token for the current method.</returns>
	SymbolToken Token { get; }

	/// <summary>Gets the namespace that the current method is defined within.</summary>
	/// <returns>The namespace that the current method is defined within.</returns>
	ISymbolNamespace GetNamespace();

	/// <summary>Gets the Microsoft intermediate language (MSIL) offset within the method that corresponds to the specified position.</summary>
	/// <param name="document">The document for which the offset is requested.</param>
	/// <param name="line">The document line corresponding to the offset.</param>
	/// <param name="column">The document column corresponding to the offset.</param>
	/// <returns>The offset within the specified document.</returns>
	int GetOffset(ISymbolDocument document, int line, int column);

	/// <summary>Gets the parameters for the current method.</summary>
	/// <returns>The array of parameters for the current method.</returns>
	ISymbolVariable[] GetParameters();

	/// <summary>Gets an array of start and end offset pairs that correspond to the ranges of Microsoft intermediate language (MSIL) that a given position covers within this method.</summary>
	/// <param name="document">The document for which the offset is requested.</param>
	/// <param name="line">The document line corresponding to the ranges.</param>
	/// <param name="column">The document column corresponding to the ranges.</param>
	/// <returns>An array of start and end offset pairs.</returns>
	int[] GetRanges(ISymbolDocument document, int line, int column);

	ISymbolScope GetScope(int offset);

	void GetSequencePoints(int[] offsets, ISymbolDocument[] documents, int[] lines, int[] columns, int[] endLines, int[] endColumns);

	bool GetSourceStartEnd(ISymbolDocument[] docs, int[] lines, int[] columns);
}
