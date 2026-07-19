using Meta.WitAi;
using Meta.WitAi.Configuration;

namespace Oculus.Voice.Interfaces
{
	public interface IPlatformVoiceService : IVoiceService, IVoiceEventProvider, ITelemetryEventsProvider, IVoiceActivationHandler
	{
		bool PlatformSupportsWit { get; }

		void SetRuntimeConfiguration(WitRuntimeConfiguration configuration);
	}
}
namespace Oculus.Voice.Bindings.Android
{
	public interface IVCBindingEvents
	{
		void OnServiceNotAvailable(string error, string message);
	}
}
