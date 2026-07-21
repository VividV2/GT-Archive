using System.ComponentModel;
using System.ComponentModel;

namespace Oculus.Platform
{
	public enum NetSyncVoipStreamMode
	{
		[Description("UNKNOWN")]
		Unknown,
		[Description("AMBISONIC")]
		Ambisonic,
		[Description("MONO")]
		Mono
	}
}
namespace Oculus.Platform
{
	public enum LivestreamingMicrophoneStatus
	{
		[Description("UNKNOWN")]
		Unknown,
		[Description("MICROPHONE_ON")]
		MicrophoneOn,
		[Description("MICROPHONE_OFF")]
		MicrophoneOff
	}
}
