using System;
using System;

public class MothershipLogCallback(Action<MothershipLogLevel, string> logFunction) : MothershipLogDelegateWrapper
{
	private readonly Action<MothershipLogLevel, string> _logFunction = logFunction;

	public override void OnLogCallback(MothershipLogLevel level, string message)
	{
		_logFunction?.Invoke(level, message);
	}
}
