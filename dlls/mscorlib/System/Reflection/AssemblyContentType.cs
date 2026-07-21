namespace System.Reflection
{
	/// <summary>Provides information about the type of code contained in an assembly.</summary>
	/// <summary>Provides information about the type of code contained in an assembly.</summary>
	public enum AssemblyContentType
	{
		/// <summary>The assembly contains .NET Framework code.</summary>
		/// <summary>The assembly contains .NET Framework code.</summary>
		Default,
		/// <summary>The assembly contains Windows Runtime code.</summary>
		/// <summary>The assembly contains Windows Runtime code.</summary>
		WindowsRuntime
	}
}
namespace System.Runtime.Serialization.Formatters.Binary
{
	[Serializable]
	[Flags]
	internal enum MessageEnum
	{
		NoArgs = 1,
		ArgsInline = 2,
		ArgsIsArray = 4,
		ArgsInArray = 8,
		NoContext = 0x10,
		ContextInline = 0x20,
		ContextInArray = 0x40,
		MethodSignatureInArray = 0x80,
		PropertyInArray = 0x100,
		NoReturnValue = 0x200,
		ReturnValueVoid = 0x400,
		ReturnValueInline = 0x800,
		ReturnValueInArray = 0x1000,
		ExceptionInArray = 0x2000,
		GenericMethod = 0x8000
	}
}
