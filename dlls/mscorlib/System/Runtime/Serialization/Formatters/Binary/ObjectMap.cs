namespace System.Runtime.Remoting.Channels
{
	internal class ChanelSinkStackEntry(IChannelSinkBase sink, object state, ChanelSinkStackEntry next)
	{
		public IChannelSinkBase Sink = sink;

		public object State = state;

		public ChanelSinkStackEntry Next = next;
	}
}
namespace System.Security.Claims
{
}
