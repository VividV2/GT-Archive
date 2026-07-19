using System.Collections.Generic;

namespace GorillaNetworking;

public struct LocalizationTelemetryData
{
	public string EventName;

	public string[] CustomTags;

	public Dictionary<string, string> BodyData;
}
