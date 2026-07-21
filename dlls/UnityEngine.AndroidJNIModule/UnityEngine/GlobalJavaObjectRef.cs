namespace UnityEngine.Android;

public enum AndroidAssetPackStatus
{
	Unknown,
	Pending,
	Downloading,
	Transferring,
	Completed,
	Failed,
	Canceled,
	WaitingForWifi,
	NotInstalled
}
namespace UnityEngine.Android
{
	public enum ExitReason
	{
		Unknown,
		ExitSelf,
		Signaled,
		LowMemory,
		Crash,
		CrashNative,
		ANR,
		InititalizationFailure,
		PermissionChange,
		ExcessiveResourceUsage,
		UserRequested,
		UserStopped,
		DependencyDied,
		Other,
		Freezer,
		PackageStateChange,
		PackageUpdated
	}
}
