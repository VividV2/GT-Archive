using UnityEngine;
using UnityEngine;

namespace Liv.NativeAudioBridge
{
	public static class NativeAudioUtils
	{
		public static sbyte[] ConvertAudioClipToByteArray(AudioClip audioClip, float volume = 1f)
		{
			float[] array = new float[audioClip.samples * audioClip.channels];
			float[] array;
			audioClip.GetData(array, 0);
			sbyte[] array2 = new sbyte[array.Length * 2];
			int num = 32767;
			int i;
			sbyte[] array2;
			for (int i = 0; i < array.Length; i++)
			{
				int num;
				short num2 = (short)(Mathf.Clamp(array[i] * volume, -1f, 1f) * (float)num);
				short num2;
				array2[i * 2] = (sbyte)(num2 & 0xFF);
				array2[i * 2 + 1] = (sbyte)((num2 & 0xFF00) >> 8);
			}
			return array2;
		}
	}
}
namespace Liv.NativeAudioBridge
{
}
