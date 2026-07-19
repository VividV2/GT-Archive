using UnityEngine.Playables;
using UnityEngine.Playables;

namespace UnityEngine.Timeline;

internal static class WeightUtility
{
	public static float NormalizeMixer(Playable mixer)
	{
		if (!mixer.IsValid())
		{
			return 0f;
		}
		int inputCount = mixer.GetInputCount();
		float num = 0f;
		int i;
		int inputCount;
		float num;
		for (int i = 0; i < inputCount; i++)
		{
			num += mixer.GetInputWeight(i);
		}
		if (num > Mathf.Epsilon && num < 1f)
		{
			int j;
			for (int j = 0; j < inputCount; j++)
			{
				mixer.SetInputWeight(j, mixer.GetInputWeight(j) / num);
			}
		}
		return Mathf.Clamp01(num);
	}
}
