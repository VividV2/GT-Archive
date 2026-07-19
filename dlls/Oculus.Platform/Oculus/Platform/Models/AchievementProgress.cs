using System;
using System;

namespace Oculus.Platform.Models
{
	public class PartyID(IntPtr o)
	{
		public readonly ulong ID = CAPI.ovr_PartyID_GetID(o);
	}
}
namespace Oculus.Platform.Models
{
	public class AchievementProgress
	{
		public readonly string Bitfield;

		public readonly ulong Count;

		public readonly bool IsUnlocked;

		public readonly string Name;

		public readonly DateTime UnlockTime;

		public AchievementProgress(IntPtr o)
		{
			Bitfield = CAPI.ovr_AchievementProgress_GetBitfield(o);
			Count = CAPI.ovr_AchievementProgress_GetCount(o);
			IsUnlocked = CAPI.ovr_AchievementProgress_GetIsUnlocked(o);
			Name = CAPI.ovr_AchievementProgress_GetName(o);
			UnlockTime = CAPI.ovr_AchievementProgress_GetUnlockTime(o);
		}
	}
}
namespace Oculus.Platform.Models
{
}
namespace Oculus.Platform.Models
{
	public class ChallengeList : DeserializableList<Challenge>
	{
		public readonly ulong TotalCount;

		public ChallengeList(IntPtr a)
		{
			base..ctor();
			num = (int)UIntPtr.op_Explicit(CAPI.ovr_ChallengeArray_GetSize(a));
			_Data = new List<Challenge>(num);
			i = 0;
			for (; i < num; i = i + 1)
			{
				_Data.Add(new Challenge(CAPI.ovr_ChallengeArray_GetElement(a, UIntPtr.op_Explicit((ulong)i))));
			}
			TotalCount = CAPI.ovr_ChallengeArray_GetTotalCount(a);
			_PreviousUrl = CAPI.ovr_ChallengeArray_GetPreviousUrl(a);
			_NextUrl = CAPI.ovr_ChallengeArray_GetNextUrl(a);
		}
	}
}
