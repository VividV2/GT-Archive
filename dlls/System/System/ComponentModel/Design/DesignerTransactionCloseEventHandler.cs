namespace System.Collections.Generic
{
	/// <summary>Provides the base interface for the abstraction of sets.</summary>
	/// <typeparam name="T">The type of elements in the set.</typeparam>
	public interface ISet<T> : ICollection<T>, IEnumerable<T>, IEnumerable
	{
		/// <summary>Adds an element to the current set and returns a value to indicate if the element was successfully added.</summary>
		/// <param name="item">The element to add to the set.</param>
		/// <returns>
		///   <see langword="true" /> if the element is added to the set; <see langword="false" /> if the element is already in the set.</returns>
		new bool Add(T item);

		void UnionWith(IEnumerable<T> other);

		void IntersectWith(IEnumerable<T> other);

		void ExceptWith(IEnumerable<T> other);

		void SymmetricExceptWith(IEnumerable<T> other);

		bool IsSubsetOf(IEnumerable<T> other);

		bool IsSupersetOf(IEnumerable<T> other);

		bool IsProperSupersetOf(IEnumerable<T> other);

		bool IsProperSubsetOf(IEnumerable<T> other);

		bool Overlaps(IEnumerable<T> other);

		bool SetEquals(IEnumerable<T> other);
	}
}
namespace System.Diagnostics
{
}
