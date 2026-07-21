using System;

namespace Photon.Voice
{
	public interface IEncoderDirectImage : IEncoderDirect<ImageBufferNative>, IEncoder, IDisposable
	{
		ImageFormat ImageFormat { get; }
	}
}
namespace Photon.Voice
{
}
namespace Photon.Voice.IOS
{
}
