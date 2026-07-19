using System;
using System.Collections.Generic;
using Meta.Voice.Net.PubSub;
using Meta.WitAi.Json;
using Meta.WitAi.Json;

namespace Meta.Voice.Audio
{
	public interface IAudioPlayer
	{
		IAudioClipStream ClipStream { get; }

		bool IsPlaying { get; }

		bool CanSetElapsedSamples { get; }

		int ElapsedSamples { get; }

		void Init();

		string GetPlaybackErrors();

		void Play(IAudioClipStream clipStream, int offsetSamples, WitResponseNode speechNode);

		void Pause();

		void Resume();

		void Stop();
	}
}
namespace Meta.Voice.Net.WebSockets
{
	public interface IWitWebSocketClient : IPubSubSubscriber
	{
		WitWebSocketSettings Settings { get; }

		WitWebSocketConnectionState ConnectionState { get; }

		bool IsAuthenticated { get; }

		bool IsUploading { get; }

		bool IsDownloading { get; }

		bool IsReferenced { get; }

		bool IsReconnecting { get; }

		int ReferenceCount { get; }

		int FailedConnectionAttempts { get; }

		DateTime LastResponseTime { get; }

		Dictionary<string, IWitWebSocketRequest> Requests { get; }

		event Action<WitWebSocketConnectionState> OnConnectionStateChanged;

		event WitWebSocketResponseProcessor OnProcessForwardedResponse;

		event Action<string, IWitWebSocketRequest> OnTopicRequestTracked;

		void Connect();

		void Disconnect();

		void ForceDisconnect();

		bool SendRequest(IWitWebSocketRequest request);

		bool TrackRequest(IWitWebSocketRequest request);

		bool UntrackRequest(IWitWebSocketRequest request);

		bool UntrackRequest(string requestId);

		void Unsubscribe(string topicId, bool ignoreRefCount);
	}
}
namespace Meta.Voice.Net.WebSockets
{
}
