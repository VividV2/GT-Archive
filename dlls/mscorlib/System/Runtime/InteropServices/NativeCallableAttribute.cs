namespace System.Runtime.InteropServices
{
	[AttributeUsage(AttributeTargets.Method)]
	internal sealed class NativeCallableAttribute : Attribute
	{
		public string EntryPoint;

		public CallingConvention CallingConvention;
	}
}
namespace System.Runtime.InteropServices
{
}
namespace System.Runtime.Serialization.Formatters.Binary
{
}
