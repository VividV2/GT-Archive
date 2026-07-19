namespace Unity.Collections;

internal sealed class BitField64DebugView(BitField64 data)
{
	private BitField64 Data = data;

	public bool[] Bits
	{
		get
		{
			bool[] array = new bool[64];
			int i;
			bool[] array;
			for (int i = 0; i < 64; i++)
			{
				array[i] = Data.IsSet(i);
			}
			return array;
		}
	}
}
