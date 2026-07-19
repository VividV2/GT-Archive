using System.ComponentModel;
using System.ComponentModel;
using System.ComponentModel;

namespace Oculus.Platform;

public enum RichPresenceExtraContext
{
	[Description("UNKNOWN")]
	Unknown,
	[Description("NONE")]
	None,
	[Description("CURRENT_CAPACITY")]
	CurrentCapacity,
	[Description("STARTED_AGO")]
	StartedAgo,
	[Description("ENDING_IN")]
	EndingIn,
	[Description("LOOKING_FOR_A_MATCH")]
	LookingForAMatch
}
namespace Oculus.Platform
{
	public enum ProductType
	{
		[Description("UNKNOWN")]
		Unknown,
		[Description("DURABLE")]
		DURABLE,
		[Description("CONSUMABLE")]
		CONSUMABLE,
		[Description("SUBSCRIPTION")]
		SUBSCRIPTION
	}
}
