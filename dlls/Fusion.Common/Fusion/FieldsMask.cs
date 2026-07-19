using System;

namespace Fusion;

[Serializable]
public abstract class FieldsMask
{
	public Mask256 Mask;

	protected FieldsMask(Mask256 mask)
	{
		Mask = mask;
	}

	protected FieldsMask(long a, long b, long c, long d)
	{
		Mask = default(Mask256);
	}

	protected FieldsMask()
	{
	}

	public static implicit operator Mask256(FieldsMask mask)
	{
		return mask.Mask;
	}
}
