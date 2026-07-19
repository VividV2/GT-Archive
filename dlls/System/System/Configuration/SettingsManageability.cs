namespace Microsoft.Win32;

public delegate void UserPreferenceChangedEventHandler(object sender, UserPreferenceChangedEventArgs e);
namespace System.Collections.Specialized
{
}
namespace System.Net.Mail
{
	[Flags]
	public enum DeliveryNotificationOptions
	{
		None = 0,
		OnSuccess = 1,
		OnFailure = 2,
		Delay = 4,
		Never = 0x8000000
	}
}
