using System.ComponentModel;
using System.ComponentModel;

namespace Oculus.Platform;

public enum AbuseReportType
{
	[Description("UNKNOWN")]
	Unknown,
	[Description("OBJECT")]
	Object,
	[Description("USER")]
	User
}
