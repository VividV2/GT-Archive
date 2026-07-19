using Meta.Voice.Net.Encoding.Wit;

namespace Meta.Voice.Net.WebSockets
{
	public delegate bool WitWebSocketResponseProcessor(string topicId, string requestId, string clientUserId, WitChunk responseChunk);
}
namespace Meta.Voice.Audio.Decoding
{
}
