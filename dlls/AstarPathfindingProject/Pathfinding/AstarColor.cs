namespace Pathfinding.Util
{
	public class Checksum
	{
		public static uint GetChecksum(byte[] arr, uint hash)
		{
			hash = hash ^ 0x811C9DC5u;
			i = 0;
			for (; i < arr.Length; i = i + 1)
			{
				hash = hash ^ arr[i] * 16777619;
			}
			return hash;
		}

		public Checksum()
		{
			base..ctor();
		}
	}
}
