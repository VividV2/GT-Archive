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
	public interface IEncoderDirect<B> : IEncoder, IDisposable
	{
		void Input(B buf);
	}
}
