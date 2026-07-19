namespace System.Drawing
{
	internal enum Status
	{
		Ok,
		GenericError,
		InvalidParameter,
		OutOfMemory,
		ObjectBusy,
		InsufficientBuffer,
		NotImplemented,
		Win32Error,
		WrongState,
		Aborted,
		FileNotFound,
		ValueOverflow,
		AccessDenied,
		UnknownImageFormat,
		FontFamilyNotFound,
		FontStyleNotFound,
		NotTrueTypeFont,
		UnsupportedGdiplusVersion,
		GdiplusNotInitialized,
		PropertyNotFound,
		PropertyNotSupported,
		ProfileNotFound
	}
}
namespace System.Drawing
{
	[AttributeUsage(AttributeTargets.Assembly)]
	public class BitmapSuffixInSatelliteAssemblyAttribute : Attribute
	{
		public BitmapSuffixInSatelliteAssemblyAttribute()
		{
			base..ctor();
		}
	}
}
