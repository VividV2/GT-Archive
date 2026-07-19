using System;

namespace Photon.Voice.IOS
{
	public enum AudioSessionCategoryOption
	{
		MixWithOthers = 1,
		DuckOthers = 2,
		AllowBluetooth = 4,
		DefaultToSpeaker = 8
	}
}
namespace Photon.Voice
{
	internal class UnsupportedSampleTypeException : Exception
	{
		public UnsupportedSampleTypeException(Type t)
			: base("[PV] unsupported sample type: " + t)
		{
		}
	}
}
