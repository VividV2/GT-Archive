using System;
using UnityEngine;

namespace emotitron.Compression;

[Serializable]
public abstract class LiteCrusher
{
	[SerializeField]
	protected int bits;

	public static int GetBitsForMaxValue(uint maxvalue)
	{
		for (int i = 0; i < 32; i++)
		{
			if (maxvalue >> i == 0)
			{
				return i;
			}
		}
		return 32;
	}
}
