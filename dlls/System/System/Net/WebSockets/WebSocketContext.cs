namespace System.Net;

internal static class NclConstants
{
	internal static readonly object Sentinel;

	internal static readonly object[] EmptyObjectArray;

	internal static readonly Uri[] EmptyUriArray;

	internal static readonly byte[] CRLF;

	internal static readonly byte[] ChunkTerminator;

	static NclConstants()
	{
		Sentinel = new object();
		EmptyObjectArray = new object[0];
		EmptyUriArray = new Uri[0];
		CRLF = new byte[2] { 13, 10 };
		ChunkTerminator = ;
	}
}
