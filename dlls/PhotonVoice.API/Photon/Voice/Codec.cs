namespace Photon.Voice
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
}
namespace Photon.Voice
{
	public interface ILocalVoiceAudio
	{
		IVoiceDetector VoiceDetector { get; }

		ILevelMeter LevelMeter { get; }

		bool VoiceDetectorCalibrating { get; }

		void VoiceDetectorCalibrate(int durationMs, Action<float> onCalibrated = null);
	}
}
namespace Photon.Voice
{
}
namespace Photon.Voice
{
}
