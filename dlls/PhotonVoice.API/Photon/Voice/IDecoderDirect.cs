using System;

namespace Photon.Voice
{
	public interface IDecoderDirect<B> : IDecoder, IDisposable
	{
		Action<B> Output { get; set; }
	}
}
namespace Photon.Voice
{
	public enum Rotation
	{
		Undefined = -1,
		Rotate0 = 0,
		Rotate90 = 90,
		Rotate180 = 180,
		Rotate270 = 270
	}
}
namespace Photon.Voice
{
}
namespace Photon.Voice
{
}
