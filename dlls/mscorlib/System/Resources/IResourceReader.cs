namespace System.Reflection
{
	[Flags]
	public enum GenericParameterAttributes
	{
		None = 0,
		VarianceMask = 3,
		Covariant = 1,
		Contravariant = 2,
		SpecialConstraintMask = 0x1C,
		ReferenceTypeConstraint = 4,
		NotNullableValueTypeConstraint = 8,
		DefaultConstructorConstraint = 0x10
	}
}
namespace System.Reflection
{
	public enum MethodImplAttributes
	{
		CodeTypeMask = 3,
		IL = 0,
		Native = 1,
		OPTIL = 2,
		Runtime = 3,
		ManagedMask = 4,
		Unmanaged = 4,
		Managed = 0,
		ForwardRef = 16,
		PreserveSig = 128,
		InternalCall = 4096,
		Synchronized = 32,
		NoInlining = 8,
		AggressiveInlining = 256,
		NoOptimization = 64,
		MaxMethodImplVal = 65535,
		SecurityMitigations = 1024
	}
}
namespace System.Threading.Tasks
{
}
