using System;

namespace Photon.Voice
{
	public interface IResettable
	{
		void Reset();
	}
}
namespace Photon.Voice
{
	public interface ILocalVoiceAudio
	{
		AudioUtil.IVoiceDetector VoiceDetector { get; }

		AudioUtil.ILevelMeter LevelMeter { get; }

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
