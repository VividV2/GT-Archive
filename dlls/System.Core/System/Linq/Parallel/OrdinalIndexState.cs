namespace System.IO.Pipes;

/// <summary>Provides options for creating a <see cref="T:System.IO.Pipes.PipeStream" /> object. This enumeration has a <see cref="T:System.FlagsAttribute" /> attribute that allows a bitwise combination of its member values.</summary>
/// <summary>Provides options for creating a <see cref="T:System.IO.Pipes.PipeStream" /> object. This enumeration has a <see cref="T:System.FlagsAttribute" /> attribute that allows a bitwise combination of its member values.</summary>
[Flags]
public enum PipeOptions
{
	/// <summary>Indicates that there are no additional parameters.</summary>
	/// <summary>Indicates that there are no additional parameters.</summary>
	None = 0,
	/// <summary>Indicates that the system should write through any intermediate cache and go directly to the pipe.</summary>
	/// <summary>Indicates that the system should write through any intermediate cache and go directly to the pipe.</summary>
	WriteThrough = int.MinValue,
	/// <summary>Indicates that the pipe can be used for asynchronous reading and writing.</summary>
	/// <summary>Indicates that the pipe can be used for asynchronous reading and writing.</summary>
	Asynchronous = 0x40000000,
	CurrentUserOnly = 0x20000000
}
namespace System.Collections.Generic
{
}
namespace System.Linq.Expressions.Compiler
{
}
namespace System.Security.Cryptography.X509Certificates
{
}
namespace System.Linq
{
}
namespace System.Linq.Parallel
{
	internal enum OrdinalIndexState : byte
	{
		Indexable,
		Correct,
		Increasing,
		Shuffled
	}
}
