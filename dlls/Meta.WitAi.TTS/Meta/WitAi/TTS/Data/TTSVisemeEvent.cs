using System;
using UnityEngine.Scripting;
using System;

namespace Meta.WitAi.TTS.Data
{
	[Serializable]
	public class TTSVisemeEvent : TTSEvent<Viseme>
	{
		[Preserve]
		public static Viseme GetVisemeAot(string inViseme)
		{
			Enum.TryParse<Viseme>(inViseme, out var result);
			return result;
		}
	}
}
namespace Meta.WitAi.TTS.Data
{
	[Serializable]
	public class TTSStringEvent : TTSEvent<string>
	{
	}
}
namespace Meta.WitAi.TTS.Data
{
}
