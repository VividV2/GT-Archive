using System;

namespace UnityEngine;

public enum FFTWindow
{
	Rectangular,
	Triangle,
	Hamming,
	Hanning,
	Blackman,
	BlackmanHarris
}
namespace UnityEngine
{
	public enum AudioSpeakerMode
	{
		[Obsolete("Raw speaker mode is not supported. Do not use.", true)]
		Raw,
		Mono,
		Stereo,
		Quad,
		Surround,
		Mode5point1,
		Mode7point1,
		Prologic
	}
}
