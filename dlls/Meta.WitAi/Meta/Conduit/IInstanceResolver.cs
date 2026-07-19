using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace Meta.Conduit
{
	internal interface IInstanceResolver
	{
		IEnumerable<object> GetObjectsOfType(Type type);
	}
}
namespace Meta.Voice.Net.WebSockets
{
}
namespace Meta.Voice.Net.WebSockets
{
	public interface IWebSocketProvider
	{
		IWebSocket GetWebSocket(string url, Dictionary<string, string> headers);
	}
}
namespace Meta.WitAi.Utilities
{
}
