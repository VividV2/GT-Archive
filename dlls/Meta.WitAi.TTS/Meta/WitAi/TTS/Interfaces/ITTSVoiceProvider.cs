using System;
using System.Threading.Tasks;
using Meta.WitAi.TTS.Data;
using Meta.WitAi.TTS.Data;

namespace Meta.WitAi.TTS.Interfaces
{
	public interface ITTSWebHandler
	{
		string GetWebErrors(TTSClipData clipData);

		TTSClipData CreateClipData(string clipId, string textToSpeak, TTSVoiceSettings voiceSettings, TTSDiskCacheSettings diskCacheSettings);

		bool DecodeTtsFromJson(Meta.WitAi.Json.WitResponseNode responseNode, out string textToSpeak, out TTSVoiceSettings voiceSettings);

		System.Threading.Tasks.Task<string> RequestStreamFromWeb(TTSClipData clipData, System.Action<TTSClipData> onReady);

		System.Threading.Tasks.Task<string> IsDownloadedToDisk(string diskPath);

		System.Threading.Tasks.Task<string> RequestStreamFromDisk(TTSClipData clipData, string diskPath, System.Action<TTSClipData> onReady);

		System.Threading.Tasks.Task<string> RequestDownloadFromWeb(TTSClipData clipData, string diskPath);

		bool CancelRequests(TTSClipData clipData);
	}
}
namespace Meta.WitAi.TTS.Interfaces
{
	public interface ITTSVoiceProvider
	{
		TTSVoiceSettings VoiceDefaultSettings { get; }

		TTSVoiceSettings[] PresetVoiceSettings { get; }
	}
}
