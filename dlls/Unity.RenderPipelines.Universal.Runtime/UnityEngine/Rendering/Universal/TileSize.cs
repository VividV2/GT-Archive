namespace UnityEngine.Rendering.Universal
{
	internal enum TileSize
	{
		_8 = 8,
		_16 = 0x10,
		_32 = 0x20,
		_64 = 0x40
	}
}
namespace UnityEngine.Rendering.Universal
{
	public struct TileData
	{
		public uint tileID;

		public uint listBitMask;

		public uint relLightOffset;

		public uint unused;
	}
}
