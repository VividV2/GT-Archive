namespace System.Data;

/// <summary>Returns a singleton instance of the <see cref="T:System.Data.DataRowComparer`1" /> class.</summary>
public static class DataRowComparer
{
	/// <summary>Gets a singleton instance of <see cref="T:System.Data.DataRowComparer`1" />. This property is read-only.</summary>
	/// <returns>An instance of a <see cref="T:System.Data.DataRowComparer`1" />.</returns>
	public static DataRowComparer<DataRow> Default => DataRowComparer<DataRow>.Default;

	internal static bool AreEqual(object a, object b)
	{
		if (a == b)
		{
			return true;
		}
		if (a == null || a == DBNull.Value || b == null || b == DBNull.Value)
		{
			return false;
		}
		if (!a.Equals(b))
		{
			if (a.GetType().IsArray)
			{
				return CompareArray((Array)a, b as Array);
			}
			return false;
		}
		return true;
	}

	private static bool AreElementEqual(object a, object b)
	{
		if (a == b)
		{
			return true;
		}
		if (a == null || a == DBNull.Value || b == null || b == DBNull.Value)
		{
			return false;
		}
		return a.Equals(b);
	}

	private static bool CompareArray(Array a, Array b)
	{
		if (b == null || 1 != a.Rank || 1 != b.Rank || a.Length != b.Length)
		{
			return false;
		}
		int num = a.GetLowerBound(0);
		int num2 = b.GetLowerBound(0);
		if (a.GetType() == b.GetType() && num == 0 && num2 == 0)
		{
			switch (Type.GetTypeCode(a.GetType().GetElementType()))
			{
			case TypeCode.Byte:
				return CompareEquatableArray((byte[])a, (byte[])b);
			case TypeCode.Int16:
				return CompareEquatableArray((short[])a, (short[])b);
			case TypeCode.Int32:
				return CompareEquatableArray((int[])a, (int[])b);
			case TypeCode.Int64:
				return CompareEquatableArray((long[])a, (long[])b);
			case TypeCode.String:
				return CompareEquatableArray((string[])a, (string[])b);
			}
		}
		int num3 = num + a.Length;
		while (num < num3)
		{
			if (!AreElementEqual(a.GetValue(num), b.GetValue(num2)))
			{
				return false;
			}
			num++;
			num2++;
		}
		return true;
	}

	private static bool CompareEquatableArray<TElem>(TElem[] a, TElem[] b) where TElem : IEquatable<TElem>
	{
		for (int i = 0; i < a.Length; i++)
		{
			ref readonly TElem reference = ref a[i];
			TElem other = b[i];
			if (!reference.Equals(other))
			{
				return false;
			}
		}
		return true;
	}
}
