namespace UnityEngine.Diagnostics
{
	public enum ForcedCrashCategory
	{
		AccessViolation,
		FatalError,
		Abort,
		PureVirtualFunction,
		MonoAbort
	}
}
namespace UnityEngine
{
	public interface ILogHandler
	{
		void LogFormat(LogType logType, Object context, string format, params object[] args);

		void LogException(Exception exception, Object context);
	}
}
