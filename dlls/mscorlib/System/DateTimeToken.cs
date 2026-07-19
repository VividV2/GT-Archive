namespace System.Runtime.Versioning
{
	[Flags]
	internal enum SxSRequirements
	{
		None = 0,
		AppDomainID = 1,
		ProcessID = 2,
		CLRInstanceID = 4,
		AssemblyName = 8,
		TypeName = 0x10
	}
}
namespace System
{
	internal struct DateTimeToken
	{
		internal DateTimeParse.DTT dtt;

		internal TokenType suffix;

		internal int num;
	}
}
