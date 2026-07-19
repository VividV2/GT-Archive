namespace System.Net
{
	internal enum HttpProcessingResult
	{
		Continue,
		ReadWait,
		WriteWait
	}
}
namespace System.Net
{
	internal class ReceiveState
	{
		private const int bufferSize = 1024;

		internal ResponseDescription Resp;

		internal int ValidThrough;

		internal byte[] Buffer;

		internal CommandStream Connection;

		internal ReceiveState(CommandStream connection)
		{
			Connection = connection;
			Resp = new ResponseDescription();
			Buffer = new byte[1024];
			ValidThrough = 0;
		}
	}
}
namespace System.Net
{
}
