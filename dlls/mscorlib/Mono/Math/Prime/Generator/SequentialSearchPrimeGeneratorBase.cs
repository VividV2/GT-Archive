namespace System
{
	public interface IAsyncDisposable
	{
		ValueTask DisposeAsync();
	}
}
