namespace UnityEngine.UIElements
{
	public enum PickingMode
	{
		Position,
		Ignore
	}
}
namespace UnityEngine.UIElements.UIR
{
	internal struct GfxUpdateBufferRange
	{
		public uint offsetFromWriteStart;

		public uint size;

		public UIntPtr source;
	}
}
