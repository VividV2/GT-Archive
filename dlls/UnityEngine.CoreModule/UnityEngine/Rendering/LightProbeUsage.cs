namespace Unity.Collections
{
	[AttributeUsage(AttributeTargets.Field)]
	[RequiredByNativeCode]
	public sealed class NativeFixedLengthAttribute : Attribute
	{
		public int FixedLength;

		public NativeFixedLengthAttribute(int fixedLength)
		{
			base..ctor();
			FixedLength = fixedLength;
		}
	}
}
namespace UnityEngine
{
}
namespace UnityEngine.Rendering
{
}
