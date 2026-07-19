namespace System.Net
{
	internal enum WebExceptionInternalStatus
	{
		RequestFatal,
		ServicePointFatal,
		Recoverable,
		Isolated
	}
}
namespace System.Net
{
	internal enum WriteBufferState
	{
		Disabled,
		Headers,
		Buffer,
		Playback
	}
}
