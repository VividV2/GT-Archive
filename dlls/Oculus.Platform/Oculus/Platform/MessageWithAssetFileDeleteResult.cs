using System.ComponentModel;
using System.ComponentModel;

namespace Oculus.Platform.Models
{
}
namespace Oculus.Platform
{
	public enum VoipSampleRate
	{
		[Description("UNKNOWN")]
		Unknown,
		[Description("HZ24000")]
		HZ24000,
		[Description("HZ44100")]
		HZ44100,
		[Description("HZ48000")]
		HZ48000
	}
}
