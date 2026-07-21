using Newtonsoft.Json;

namespace Modio.API.SchemaDefinitions
{
}
namespace Modio.API.SchemaDefinitions
{
	[JsonObject]
	internal readonly struct ModerationRulesHistoryRequestObject(string timeframe)
	{
		internal readonly string Timeframe = timeframe;
	}
}
