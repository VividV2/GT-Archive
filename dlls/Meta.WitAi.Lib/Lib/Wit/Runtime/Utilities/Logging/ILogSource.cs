using Meta.Voice.Logging;

namespace Meta.Voice.Logging;

public interface IVLogger : ICoreLogger
{
	void Flush(CorrelationID correlationId);

	void Flush();
}
namespace Lib.Wit.Runtime.Utilities.Logging
{
	public interface ILogSource
	{
		IVLogger Logger { get; }
	}
}
