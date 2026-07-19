using System;
using UnityEngine;
using System;
using UnityEngine;

namespace Liv.NativeAudioBridge
{
	public static class NativeAudioPlayerFactory
	{
		public static INativeAudioPlayer CreateNativeAudioPlayer()
		{
			return new NativeAudioPlayerWindows();
		}
	}
}
namespace Liv.NativeAudioBridge
{
	public interface INativeAudioPlayer : IDisposable
	{
		void PreloadAudioClip(AudioClip audioClip, float volume, bool forceReload = false);

		void PlayAudioClip(AudioClip audioClip, float volume);

		void StopAllAudio();
	}
}
