using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System;

/// <summary>Represents a value tuple with 6 components.</summary>
/// <typeparam name="T1">The type of the value tuple's first element.</typeparam>
/// <typeparam name="T2">The type of the value tuple's second element.</typeparam>
/// <typeparam name="T3">The type of the value tuple's third element.</typeparam>
/// <typeparam name="T4">The type of the value tuple's fourth element.</typeparam>
/// <typeparam name="T5">The type of the value tuple's fifth element.</typeparam>
/// <typeparam name="T6">The type of the value tuple's sixth element.</typeparam>
[Serializable]
[StructLayout(LayoutKind.Auto)]
public struct ValueTuple<T1, T2, T3, T4, T5, T6> : IEquatable<(T1, T2, T3, T4, T5, T6)>, IStructuralEquatable, IStructuralComparable, IComparable, IComparable<(T1, T2, T3, T4, T5, T6)>, IValueTupleInternal, ITuple
{
	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`6" /> instance's first element.</summary>
	public T1 Item1;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`6" /> instance's second element.</summary>
	public T2 Item2;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`6" /> instance's third element.</summary>
	public T3 Item3;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`6" /> instance's fourth element.</summary>
	public T4 Item4;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`6" /> instance's fifth element.</summary>
	public T5 Item5;

	/// <summary>Gets the value of the current <see cref="T:System.ValueTuple`6" /> instance's sixth element.</summary>
	public T6 Item6;

	/// <summary>Gets the number of elements in the <see langword="ValueTuple" />.</summary>
	/// <returns>6, the number of elements in a <see cref="T:System.ValueTuple`6" /> object.</returns>
	int ITuple.Length => 6;

	/// <summary>Gets the value of the specified <see langword="ValueTuple" /> element.</summary>
	/// <param name="index">The index of the specified <see langword="ValueTuple" /> element. <paramref name="index" /> can range from 0 to 5.</param>
	/// <returns>The value of the <see langword="ValueTuple" /> element at the specified position.</returns>
	/// <exception cref="T:System.IndexOutOfRangeException">
	///   <paramref name="index" /> is less than 0 or greater than 5.</exception>
	object ITuple.this[int index] => index switch
	{
		0 => Item1, 
		1 => Item2, 
		2 => Item3, 
		3 => Item4, 
		4 => Item5, 
		5 => Item6, 
		_ => throw new IndexOutOfRangeException(), 
	};

	/// <summary>Initializes a new <see cref="T:System.ValueTuple`6" /> instance.</summary>
	/// <param name="item1">The value tuple's first element.</param>
	/// <param name="item2">The value tuple's second element.</param>
	/// <param name="item3">The value tuple's third element.</param>
	/// <param name="item4">The value tuple's fourth element.</param>
	/// <param name="item5">The value tuple's fifth element.</param>
	/// <param name="item6">The value tuple's sixth element.</param>
	public ValueTuple(T1 item1, T2 item2, T3 item3, T4 item4, T5 item5, T6 item6)
	{
		Item1 = item1;
		Item2 = item2;
		Item3 = item3;
		Item4 = item4;
		Item5 = item5;
		Item6 = item6;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`6" /> instance is equal to a specified object.</summary>
	/// <param name="obj">The object to compare with this instance.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified object; otherwise, <see langword="false" />.</returns>
	public override bool Equals(object obj)
	{
		if (obj is ValueTuple<T1, T2, T3, T4, T5, T6>)
		{
			return Equals(((T1, T2, T3, T4, T5, T6))obj);
		}
		return false;
	}

	public bool Equals((T1, T2, T3, T4, T5, T6) other)
	{
		if (EqualityComparer<T1>.Default.Equals(Item1, other.Item1) && EqualityComparer<T2>.Default.Equals(Item2, other.Item2) && EqualityComparer<T3>.Default.Equals(Item3, other.Item3) && EqualityComparer<T4>.Default.Equals(Item4, other.Item4) && EqualityComparer<T5>.Default.Equals(Item5, other.Item5))
		{
			return EqualityComparer<T6>.Default.Equals(Item6, other.Item6);
		}
		return false;
	}

	/// <summary>Returns a value that indicates whether the current <see cref="T:System.ValueTuple`6" /> instance is equal to a specified object based on a specified comparison method.</summary>
	/// <param name="other">The object to compare with this instance.</param>
	/// <param name="comparer">An object that defines the method to use to evaluate whether the two objects are equal.</param>
	/// <returns>
	///   <see langword="true" /> if the current instance is equal to the specified objects; otherwise, <see langword="false" />.</returns>
	bool IStructuralEquatable.Equals(object other, IEqualityComparer comparer)
	{
		if (other == null || !(other is (T1, T2, T3, T4, T5, T6) tuple))
		{
			return false;
		}
		if (comparer.Equals(Item1, tuple.Item1) && comparer.Equals(Item2, tuple.Item2) && comparer.Equals(Item3, tuple.Item3) && comparer.Equals(Item4, tuple.Item4) && comparer.Equals(Item5, tuple.Item5))
		{
			return comparer.Equals(Item6, tuple.Item6);
		}
		return false;
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`6" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="obj" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IComparable.CompareTo(object other)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is ValueTuple<T1, T2, T3, T4, T5, T6>))
		{
			throw new ArgumentException(SR.Format("Argument must be of type {0}.", GetType().ToString()), "other");
		}
		return CompareTo(((T1, T2, T3, T4, T5, T6))other);
	}

	public int CompareTo((T1, T2, T3, T4, T5, T6) other)
	{
		int num = Comparer<T1>.Default.Compare(Item1, other.Item1);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T2>.Default.Compare(Item2, other.Item2);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T3>.Default.Compare(Item3, other.Item3);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T4>.Default.Compare(Item4, other.Item4);
		if (num != 0)
		{
			return num;
		}
		num = Comparer<T5>.Default.Compare(Item5, other.Item5);
		if (num != 0)
		{
			return num;
		}
		return Comparer<T6>.Default.Compare(Item6, other.Item6);
	}

	/// <summary>Compares the current <see cref="T:System.ValueTuple`6" /> instance to a specified object by using a specified comparer and returns an integer that indicates whether the current object is before, after, or in the same position as the specified object in the sort order.</summary>
	/// <param name="other">The object to compare with the current instance.</param>
	/// <param name="comparer">An object that provides custom rules for comparison.</param>
	/// <returns>A signed integer that indicates the relative position of this instance and <paramref name="other" /> in the sort order, as shown in the following table.  
	///   Value  
	///
	///   Description  
	///
	///   A negative integer  
	///
	///   This instance precedes <paramref name="other" />.  
	///
	///   Zero  
	///
	///   This instance and <paramref name="other" /> have the same position in the sort order.  
	///
	///   A positive integer  
	///
	///   This instance follows <paramref name="other" />.</returns>
	int IStructuralComparable.CompareTo(object other, IComparer comparer)
	{
		if (other == null)
		{
			return 1;
		}
		if (!(other is (T1, T2, T3, T4, T5, T6) tuple))
		{
			throw new ArgumentException(SR.Format("Argument must be of type {0}.", GetType().ToString()), "other");
		}
		int num = comparer.Compare(Item1, tuple.Item1);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item2, tuple.Item2);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item3, tuple.Item3);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item4, tuple.Item4);
		if (num != 0)
		{
			return num;
		}
		num = comparer.Compare(Item5, tuple.Item5);
		if (num != 0)
		{
			return num;
		}
		return comparer.Compare(Item6, tuple.Item6);
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`6" /> instance.</summary>
	/// <returns>The hash code for the current <see cref="T:System.ValueTuple`6" /> instance.</returns>
	public override int GetHashCode()
	{
		return ValueTuple.CombineHashCodes(Item1?.GetHashCode() ?? 0, Item2?.GetHashCode() ?? 0, Item3?.GetHashCode() ?? 0, Item4?.GetHashCode() ?? 0, Item5?.GetHashCode() ?? 0, Item6?.GetHashCode() ?? 0);
	}

	/// <summary>Calculates the hash code for the current <see cref="T:System.ValueTuple`6" /> instance by using a specified computation method.</summary>
	/// <param name="comparer">An object whose <see cref="M:System.Collections.IEqualityComparer.GetHashCode(System.Object)" /> method calculates the hash code of the current <see cref="T:System.ValueTuple`6" /> instance.</param>
	/// <returns>A 32-bit signed integer hash code.</returns>
	int IStructuralEquatable.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	private int GetHashCodeCore(IEqualityComparer comparer)
	{
		return ValueTuple.CombineHashCodes(comparer.GetHashCode(Item1), comparer.GetHashCode(Item2), comparer.GetHashCode(Item3), comparer.GetHashCode(Item4), comparer.GetHashCode(Item5), comparer.GetHashCode(Item6));
	}

	int IValueTupleInternal.GetHashCode(IEqualityComparer comparer)
	{
		return GetHashCodeCore(comparer);
	}

	/// <summary>Returns a string that represents the value of this <see cref="T:System.ValueTuple`6" /> instance.</summary>
	/// <returns>The string representation of this <see cref="T:System.ValueTuple`6" /> instance.</returns>
	public override string ToString()
	{
		return "(" + Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ", " + Item5?.ToString() + ", " + Item6?.ToString() + ")";
	}

	string IValueTupleInternal.ToStringEnd()
	{
		return Item1?.ToString() + ", " + Item2?.ToString() + ", " + Item3?.ToString() + ", " + Item4?.ToString() + ", " + Item5?.ToString() + ", " + Item6?.ToString() + ")";
	}
}
