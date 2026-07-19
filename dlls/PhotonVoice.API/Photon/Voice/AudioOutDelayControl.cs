namespace Photon.Voice;

public class AudioOutDelayControl
{
	public class PlayDelayConfig
	{
		public int Low { get; set; }

		public int High { get; set; }

		public int Max { get; set; }

		public int SpeedUpPerc { get; set; }

		public PlayDelayConfig()
		{
			Low = 200;
			High = 400;
			Max = 1000;
			SpeedUpPerc = 5;
		}

		public PlayDelayConfig Clone()
		{
			return new PlayDelayConfig
			{
				Low = Low,
				High = High,
				Max = Max,
				SpeedUpPerc = SpeedUpPerc
			};
		}
	}
}
