using System;

namespace POpusCodec
{
}
namespace Photon.Voice
{
	public enum Codec
	{
		Raw = 1,
		AudioOpus = 11
	}
}
namespace Photon.Voice
{
	public enum AudioSampleType
	{
		Source,
		Short,
		Float
	}
}
namespace Photon.Voice
{
	public enum FrameFlags : byte
	{
		Config = 1,
		KeyFrame = 2,
		PartialFrame = 4,
		EndOfStream = 8
	}
}
namespace Photon.Voice
{
	public interface IEncoderDirectImage : IEncoderDirect<ImageBufferNative>, IEncoder, System.IDisposable
	{
		ImageFormat ImageFormat { get; }
	}
}
namespace Photon.Voice
{
}
namespace Photon.Voice
{
	public interface ILogger
	{
		void LogError(string fmt, params object[] args);

		void LogWarning(string fmt, params object[] args);

		void LogInfo(string fmt, params object[] args);

		void LogDebug(string fmt, params object[] args);
	}
}
namespace Photon.Voice
{
}
namespace Photon.Voice
{
}
