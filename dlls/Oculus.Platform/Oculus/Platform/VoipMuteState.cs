using System.ComponentModel;

namespace Oculus.Platform.Models
{
}
namespace Oculus.Platform
{
	public enum VoipMuteState
	{
		[Description("UNKNOWN")]
		Unknown,
		[Description("MUTED")]
		Muted,
		[Description("UNMUTED")]
		Unmuted
	}
}
