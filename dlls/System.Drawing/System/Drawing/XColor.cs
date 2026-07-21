namespace System.Drawing
{
}
namespace Unity
{
}
namespace System.Drawing
{
}
namespace System.Drawing
{
	/// <summary>Specifies how to trim characters from a string that does not completely fit into a layout shape.</summary>
	/// <summary>Specifies how to trim characters from a string that does not completely fit into a layout shape.</summary>
	/// <summary>Specifies how to trim characters from a string that does not completely fit into a layout shape.</summary>
	public enum StringTrimming
	{
		/// <summary>Specifies no trimming.</summary>
		/// <summary>Specifies no trimming.</summary>
		/// <summary>Specifies no trimming.</summary>
		/// <summary>Specifies no trimming.</summary>
		None,
		/// <summary>Specifies that the text is trimmed to the nearest character.</summary>
		/// <summary>Specifies that the text is trimmed to the nearest character.</summary>
		/// <summary>Specifies that the text is trimmed to the nearest character.</summary>
		/// <summary>Specifies that the text is trimmed to the nearest character.</summary>
		Character,
		/// <summary>Specifies that text is trimmed to the nearest word.</summary>
		/// <summary>Specifies that text is trimmed to the nearest word.</summary>
		/// <summary>Specifies that text is trimmed to the nearest word.</summary>
		/// <summary>Specifies that text is trimmed to the nearest word.</summary>
		Word,
		/// <summary>Specifies that the text is trimmed to the nearest character, and an ellipsis is inserted at the end of a trimmed line.</summary>
		/// <summary>Specifies that the text is trimmed to the nearest character, and an ellipsis is inserted at the end of a trimmed line.</summary>
		/// <summary>Specifies that the text is trimmed to the nearest character, and an ellipsis is inserted at the end of a trimmed line.</summary>
		/// <summary>Specifies that the text is trimmed to the nearest character, and an ellipsis is inserted at the end of a trimmed line.</summary>
		EllipsisCharacter,
		/// <summary>Specifies that text is trimmed to the nearest word, and an ellipsis is inserted at the end of a trimmed line.</summary>
		/// <summary>Specifies that text is trimmed to the nearest word, and an ellipsis is inserted at the end of a trimmed line.</summary>
		/// <summary>Specifies that text is trimmed to the nearest word, and an ellipsis is inserted at the end of a trimmed line.</summary>
		/// <summary>Specifies that text is trimmed to the nearest word, and an ellipsis is inserted at the end of a trimmed line.</summary>
		EllipsisWord,
		/// <summary>The center is removed from trimmed lines and replaced by an ellipsis. The algorithm keeps as much of the last slash-delimited segment of the line as possible.</summary>
		/// <summary>The center is removed from trimmed lines and replaced by an ellipsis. The algorithm keeps as much of the last slash-delimited segment of the line as possible.</summary>
		/// <summary>The center is removed from trimmed lines and replaced by an ellipsis. The algorithm keeps as much of the last slash-delimited segment of the line as possible.</summary>
		/// <summary>The center is removed from trimmed lines and replaced by an ellipsis. The algorithm keeps as much of the last slash-delimited segment of the line as possible.</summary>
		EllipsisPath
	}
}
namespace System.Drawing
{
	internal struct XColor
	{
		public int pixel;

		public ushort red;

		public ushort green;

		public ushort blue;

		public sbyte flags;

		public sbyte pad;
	}
}
namespace System.Drawing
{
	/// <summary>The <see cref="T:System.Drawing.StringDigitSubstitute" /> enumeration specifies how to substitute digits in a string according to a user's locale or language.</summary>
	/// <summary>The <see cref="T:System.Drawing.StringDigitSubstitute" /> enumeration specifies how to substitute digits in a string according to a user's locale or language.</summary>
	/// <summary>The <see cref="T:System.Drawing.StringDigitSubstitute" /> enumeration specifies how to substitute digits in a string according to a user's locale or language.</summary>
	/// <summary>The <see cref="T:System.Drawing.StringDigitSubstitute" /> enumeration specifies how to substitute digits in a string according to a user's locale or language.</summary>
	public enum StringDigitSubstitute
	{
		/// <summary>Specifies a user-defined substitution scheme.</summary>
		/// <summary>Specifies a user-defined substitution scheme.</summary>
		/// <summary>Specifies a user-defined substitution scheme.</summary>
		/// <summary>Specifies a user-defined substitution scheme.</summary>
		User,
		/// <summary>Specifies to disable substitutions.</summary>
		/// <summary>Specifies to disable substitutions.</summary>
		/// <summary>Specifies to disable substitutions.</summary>
		/// <summary>Specifies to disable substitutions.</summary>
		None,
		/// <summary>Specifies substitution digits that correspond with the official national language of the user's locale.</summary>
		/// <summary>Specifies substitution digits that correspond with the official national language of the user's locale.</summary>
		/// <summary>Specifies substitution digits that correspond with the official national language of the user's locale.</summary>
		/// <summary>Specifies substitution digits that correspond with the official national language of the user's locale.</summary>
		National,
		/// <summary>Specifies substitution digits that correspond with the user's native script or language, which may be different from the official national language of the user's locale.</summary>
		/// <summary>Specifies substitution digits that correspond with the user's native script or language, which may be different from the official national language of the user's locale.</summary>
		/// <summary>Specifies substitution digits that correspond with the user's native script or language, which may be different from the official national language of the user's locale.</summary>
		/// <summary>Specifies substitution digits that correspond with the user's native script or language, which may be different from the official national language of the user's locale.</summary>
		Traditional
	}
}
namespace System.Drawing
{
}
namespace System.Drawing
{
}
namespace System.Drawing
{
}
namespace System.Drawing
{
}
namespace System.Drawing.Drawing2D
{
}
internal static class Consts
{
	public const string MonoCorlibVersion = "1A5E0066-58DC-428A-B21C-0AD6CDAE2789";

	public const string MonoVersion = "6.13.0.0";

	public const string MonoCompany = "Mono development team";

	public const string MonoProduct = "Mono Common Language Infrastructure";

	public const string MonoCopyright = "(c) Various Mono authors";

	public const string FxVersion = "4.0.0.0";

	public const string FxFileVersion = "4.6.57.0";

	public const string EnvironmentVersion = "4.0.30319.42000";

	public const string VsVersion = "0.0.0.0";

	public const string VsFileVersion = "11.0.0.0";

	private const string PublicKeyToken = "b77a5c561934e089";

	public const string AssemblyI18N = "I18N, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";

	public const string AssemblyMicrosoft_JScript = "Microsoft.JScript, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblyMicrosoft_VisualStudio = "Microsoft.VisualStudio, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblyMicrosoft_VisualStudio_Web = "Microsoft.VisualStudio.Web, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblyMicrosoft_VSDesigner = "Microsoft.VSDesigner, Version=0.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblyMono_Http = "Mono.Http, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";

	public const string AssemblyMono_Posix = "Mono.Posix, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";

	public const string AssemblyMono_Security = "Mono.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";

	public const string AssemblyMono_Messaging_RabbitMQ = "Mono.Messaging.RabbitMQ, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0738eb9f132ed756";

	public const string AssemblyCorlib = "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	public const string AssemblySystem = "System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	public const string AssemblySystem_Data = "System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	public const string AssemblySystem_Design = "System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblySystem_DirectoryServices = "System.DirectoryServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblySystem_Drawing = "System.Drawing, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblySystem_Drawing_Design = "System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblySystem_Messaging = "System.Messaging, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblySystem_Security = "System.Security, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblySystem_ServiceProcess = "System.ServiceProcess, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblySystem_Web = "System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

	public const string AssemblySystem_Windows_Forms = "System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	public const string AssemblySystem_2_0 = "System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	public const string AssemblySystemCore_3_5 = "System.Core, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	public const string AssemblySystem_Core = "System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";

	public const string WindowsBase_3_0 = "WindowsBase, Version=3.0.0.0, PublicKeyToken=31bf3856ad364e35";

	public const string AssemblyWindowsBase = "WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	public const string AssemblyPresentationCore_3_5 = "PresentationCore, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	public const string AssemblyPresentationCore_4_0 = "PresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	public const string AssemblyPresentationFramework_3_5 = "PresentationFramework, Version=3.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35";

	public const string AssemblySystemServiceModel_3_0 = "System.ServiceModel, Version=3.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
}
namespace System.Drawing
{
	internal static class AssemblyRef
	{
		public const string SystemDrawingDesign = "System.Drawing.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		public const string SystemDesign = "System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a";

		public const string SystemWindowsForms = "System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
	}
}
namespace System.Drawing.Design
{
	public class ToolboxComponentsCreatedEventArgs : EventArgs
	{
		private readonly IComponent[] comps;

		public IComponent[] Components
		{
			get
			{
				return (IComponent[])comps.Clone();
			}
		}

		public ToolboxComponentsCreatedEventArgs(IComponent[] components)
		{
			base..ctor();
			comps = components;
		}
	}
}
namespace System.Drawing.Printing
{
	internal abstract class PrintingServices
	{
		internal abstract string DefaultPrinter { get; }

		internal abstract bool IsPrinterValid(string printer);

		internal abstract void LoadPrinterSettings(string printer, PrinterSettings settings);

		internal abstract void LoadPrinterResolutions(string printer, PrinterSettings settings);

		internal abstract void GetPrintDialogInfo(string printer, ref string port, ref string type, ref string status, ref string comment);

		internal void LoadDefaultResolutions(PrinterResolutionCollection col)
		{
			col.Add(new PrinterResolution(PrinterResolutionKind.High, -4, -1));
			col.Add(new PrinterResolution(PrinterResolutionKind.Medium, -3, -1));
			col.Add(new PrinterResolution(PrinterResolutionKind.Low, -2, -1));
			col.Add(new PrinterResolution(PrinterResolutionKind.Draft, -1, -1));
		}

		protected PrintingServices()
		{
			base..ctor();
		}
	}
}
internal class SR
{
	public const string CantTellPrinterName = "(printer name protected due to security restrictions)";

	public const string CantChangeImmutableObjects = "Changes cannot be made to {0} because permissions are not valid.";

	public const string CantMakeIconTransparent = "Bitmaps that are icons cannot be made transparent. Icons natively support transparency. Use the Icon constructor to create an icon.";

	public const string ColorNotSystemColor = "The color {0} is not a system color.";

	public const string DotNET_ComponentType = ".NET Component";

	public const string GdiplusAborted = "Function was ended.";

	public const string GdiplusAccessDenied = "File access is denied.";

	public const string GdiplusCannotCreateGraphicsFromIndexedPixelFormat = "A Graphics object cannot be created from an image that has an indexed pixel format.";

	public const string GdiplusCannotSetPixelFromIndexedPixelFormat = "SetPixel is not supported for images with indexed pixel formats.";

	public const string GdiplusDestPointsInvalidParallelogram = "Destination points define a parallelogram which must have a length of 3. These points will represent the upper-left, upper-right, and lower-left coordinates (defined in that order).";

	public const string GdiplusDestPointsInvalidLength = "Destination points must be an array with a length of 3 or 4. A length of 3 defines a parallelogram with the upper-left, upper-right, and lower-left corners. A length of 4 defines a quadrilateral with the fourth element of the array specifying the lower-right coordinate.";

	public const string GdiplusFileNotFound = "File not found.";

	public const string GdiplusFontFamilyNotFound = "Font '{0}' cannot be found.";

	public const string GdiplusFontStyleNotFound = "Font '{0}' does not support style '{1}'.";

	public const string GdiplusGenericError = "A generic error occurred in GDI+.";

	public const string GdiplusInsufficientBuffer = "Buffer is too small (internal GDI+ error).";

	public const string GdiplusInvalidParameter = "Parameter is not valid.";

	public const string GdiplusInvalidRectangle = "Rectangle '{0}' cannot have a width or height equal to 0.";

	public const string GdiplusInvalidSize = "Operation requires a transformation of the image from GDI+ to GDI. GDI does not support images with a width or height greater than 32767.";

	public const string GdiplusOutOfMemory = "Out of memory.";

	public const string GdiplusNotImplemented = "Not implemented.";

	public const string GdiplusNotInitialized = "GDI+ is not properly initialized (internal GDI+ error).";

	public const string GdiplusNotTrueTypeFont = "Only TrueType fonts are supported. '{0}' is not a TrueType font.";

	public const string GdiplusNotTrueTypeFont_NoName = "Only TrueType fonts are supported. This is not a TrueType font.";

	public const string GdiplusObjectBusy = "Object is currently in use elsewhere.";

	public const string GdiplusOverflow = "Overflow error.";

	public const string GdiplusPropertyNotFoundError = "Property cannot be found.";

	public const string GdiplusPropertyNotSupportedError = "Property is not supported.";

	public const string GdiplusUnknown = "Unknown GDI+ error occurred.";

	public const string GdiplusUnknownImageFormat = "Image format is unknown.";

	public const string GdiplusUnsupportedGdiplusVersion = "Current version of GDI+ does not support this feature.";

	public const string GdiplusWrongState = "Bitmap region is already locked.";

	public const string GlobalAssemblyCache = " (Global Assembly Cache)";

	public const string GraphicsBufferCurrentlyBusy = "BufferedGraphicsContext cannot be disposed of because a buffer operation is currently in progress.";

	public const string GraphicsBufferQueryFail = "Screen-compatible bitmap cannot be created. The screen bitmap format cannot be determined.";

	public const string ToolboxItemLocked = "Toolbox item cannot be modified.";

	public const string ToolboxItemInvalidPropertyType = "Property {0} requires an argument of type {1}.";

	public const string ToolboxItemValueNotSerializable = "Data type {0} is not serializable. Items added to a property dictionary must be serializable.";

	public const string ToolboxItemInvalidKey = "Argument should be a non-empty string.";

	public const string IllegalState = "Internal state of the {0} class is invalid.";

	public const string InterpolationColorsColorBlendNotSet = "Property must be set to a valid ColorBlend object to use interpolation colors.";

	public const string InterpolationColorsCommon = "{0}{1} ColorBlend objects must be constructed with the same number of positions and color values. Positions must be between 0.0 and 1.0, 1.0 indicating the last element in the array.";

	public const string InterpolationColorsInvalidColorBlendObject = "ColorBlend object that was set is not valid.";

	public const string InterpolationColorsInvalidStartPosition = "Position's first element must be equal to 0.";

	public const string InterpolationColorsInvalidEndPosition = "Position's last element must be equal to 1.0.";

	public const string InterpolationColorsLength = "Array of colors and positions must contain at least two elements.";

	public const string InterpolationColorsLengthsDiffer = "Colors and positions do not have the same number of elements.";

	public const string InvalidArgument = "Value of '{1}' is not valid for '{0}'.";

	public const string InvalidBoundArgument = "Value of '{1}' is not valid for '{0}'. '{0}' should be greater than {2} and less than or equal to {3}.";

	public const string InvalidClassName = "Class name is not valid.";

	public const string InvalidColor = "Color '{0}' is not valid.";

	public const string InvalidDashPattern = "DashPattern value is not valid.";

	public const string InvalidEx2BoundArgument = "Value of '{1}' is not valid for '{0}'. '{0}' should be greater than or equal to {2} and less than or equal to {3}.";

	public const string InvalidFrame = "Frame is not valid. Frame must be between 0 and FrameCount.";

	public const string InvalidGDIHandle = "Win32 handle that was passed to {0} is not valid or is the wrong type.";

	public const string InvalidImage = "Image type is unknown.";

	public const string InvalidLowBoundArgumentEx = "Value of '{1}' is not valid for '{0}'. '{0}' must be greater than or equal to {2}.";

	public const string InvalidPermissionLevel = "Permission level is not valid.";

	public const string InvalidPermissionState = "Permission state is not valid.";

	public const string InvalidPictureType = "Argument '{0}' must be a picture that can be used as a {1}.";

	public const string InvalidPrinterException_InvalidPrinter = "Settings to access printer '{0}' are not valid.";

	public const string InvalidPrinterException_NoDefaultPrinter = "No printers are installed.";

	public const string InvalidPrinterHandle = "Handle {0} is not valid.";

	public const string ValidRangeX = "Parameter must be positive and < Width.";

	public const string ValidRangeY = "Parameter must be positive and < Height.";

	public const string NativeHandle0 = "Native handle is 0.";

	public const string NoDefaultPrinter = "Default printer is not set.";

	public const string NotImplemented = "Not implemented.";

	public const string PDOCbeginPrintDescr = "Occurs when the document is about to be printed.";

	public const string PDOCdocumentNameDescr = "The name of the document shown to the user.";

	public const string PDOCdocumentPageSettingsDescr = "The page settings of the page currently being printed.";

	public const string PDOCendPrintDescr = "Occurs after the document has been printed.";

	public const string PDOCoriginAtMarginsDescr = "Indicates that the graphics origin is located at the user-specified page margins.";

	public const string PDOCprintControllerDescr = "Retrieves the print controller for this document.";

	public const string PDOCprintPageDescr = "Occurs once for each page to be printed.";

	public const string PDOCprinterSettingsDescr = "Retrieves the settings for the printer the document is currently being printed to.";

	public const string PDOCqueryPageSettingsDescr = "Occurs before each page is printed.  Useful for changing PageSettings for a particular page.";

	public const string PrintDocumentDesc = "Defines an object that sends output to a printer.";

	public const string PrintingPermissionBadXml = "XML is not valid.";

	public const string PrintingPermissionAttributeInvalidPermissionLevel = "Permission level must be between PrintingPermissionLevel.NoPrinting and PrintingPermissionLevel.AllPrinting.";

	public const string PropertyValueInvalidEntry = "IDictionary parameter contains at least one entry that is not valid. Ensure all values are consistent with the object's properties.";

	public const string PSizeNotCustom = "PaperSize cannot be changed unless the Kind property is set to Custom.";

	public const string ResourceNotFound = "Resource '{1}' cannot be found in class '{0}'.";

	public const string TargetNotPrintingPermission = "Target does not have permission to print.";

	public const string TextParseFailedFormat = "Text \"{0}\" cannot be parsed. The expected text format is \"{1}\".";

	public const string TriStateCompareError = "TriState.Default cannot be converted into a Boolean.";

	public const string toStringIcon = "(Icon)";

	public const string toStringNone = "(none)";

	public const string DCTypeInvalid = "GetObjectType on this dc returned an invalid value.";

	public const string InvalidEnumArgument = "The value of argument '{0}' ({1}) is invalid for Enum type '{2}'.";

	public const string ConvertInvalidPrimitive = "{0} is not a valid value for {1}.";

	public const string LibgdiplusNotFound = "The native library \"libgdiplus\" is not installed on the system, or was otherwise unable to be loaded.";

	public static string Format(string format, params object[] args)
	{
		return string.Format(format, args);
	}

	public SR()
	{
		base..ctor();
	}
}
