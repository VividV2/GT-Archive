namespace System.IO.Compression;

internal enum BlockType
{
	Uncompressed,
	Static,
	Dynamic
}
namespace System.IO.Compression
{
	internal interface IFileFormatWriter
	{
		byte[] GetHeader();

		void UpdateWithBytesRead(byte[] buffer, int offset, int bytesToCopy);

		byte[] GetFooter();
	}
}
namespace System.IO.Compression
{
}
namespace System.IO.Compression
{
}
