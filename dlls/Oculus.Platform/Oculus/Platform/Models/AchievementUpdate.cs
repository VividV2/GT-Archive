using System;
using System.ComponentModel;
using System.ComponentModel;

namespace Oculus.Platform.Models
{
}
namespace Oculus.Platform
{
}
namespace Oculus.Platform
{
}
namespace Oculus.Platform
{
}
namespace Oculus.Platform
{
}
namespace Oculus.Platform.Models
{
	public class AchievementUpdate
	{
		public readonly bool JustUnlocked;

		public readonly string Name;

		public AchievementUpdate(IntPtr o)
		{
			JustUnlocked = CAPI.ovr_AchievementUpdate_GetJustUnlocked(o);
			Name = CAPI.ovr_AchievementUpdate_GetName(o);
		}
	}
}
namespace Oculus.Platform
{
	public enum UserOrdering
	{
		[Description("UNKNOWN")]
		Unknown,
		[Description("NONE")]
		None,
		[Description("PRESENCE_ALPHABETICAL")]
		PresenceAlphabetical
	}
}
