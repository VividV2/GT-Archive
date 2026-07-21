namespace Microsoft.Win32
{
	public delegate void TimerElapsedEventHandler(object sender, TimerElapsedEventArgs e);
}
namespace System.Diagnostics
{
	public enum PerformanceCounterCategoryType
	{
		SingleInstance = 0,
		MultiInstance = 1,
		Unknown = -1
	}
}
