using System;

namespace POpusCodec.Enums;

public enum Channels
{
	Mono = 1,
	Stereo
}
namespace Photon.Voice
{
	public interface IAudioDesc : IDisposable
	{
		int SamplingRate { get; }

		int Channels { get; }

		string Error { get; }
	}
}
namespace POpusCodec
{
}
