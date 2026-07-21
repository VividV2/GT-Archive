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
}
namespace System.Drawing.Printing
{
}
