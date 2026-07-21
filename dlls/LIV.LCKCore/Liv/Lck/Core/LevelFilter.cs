namespace Liv.Lck.Core
{
	public enum LevelFilter
	{
		Off,
		Error,
		Warn,
		Info,
		Debug,
		Trace
	}
}
namespace Liv.Lck.Core
{
	internal interface ILckTelemetryContextProvider
	{
		void SetTelemetryContext(LckTelemetryContextType contextType, Dictionary<string, object> context);

		void ClearTelemetryContext(LckTelemetryContextType contextType);
	}
}
