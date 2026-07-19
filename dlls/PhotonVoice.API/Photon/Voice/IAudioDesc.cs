namespace Photon.Voice
{
	public interface IServiceable
	{
		void Service(LocalVoice localVoice);
	}
}
namespace Photon.Voice
{
	public interface IAudioDesc : System.IDisposable
	{
		int SamplingRate { get; }

		int Channels { get; }

		string Error { get; }
	}
}
namespace Photon.Voice
{
}
