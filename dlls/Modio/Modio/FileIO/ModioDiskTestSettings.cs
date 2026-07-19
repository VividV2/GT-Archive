namespace Modio.FileIO
{
	public class ModioDiskTestSettings : IModioServiceSettings
	{
		public bool OverrideDiskSpaceRemaining;

		public int BytesRemaining;
	}
}
namespace Modio.Errors
{
	public enum TempModsErrorCode : long
	{
		NONE = 0L,
		UNKNOWN = -2147483648L,
		CANT_INSTALL_TAINTED_MOD = -2147483550L
	}
}
