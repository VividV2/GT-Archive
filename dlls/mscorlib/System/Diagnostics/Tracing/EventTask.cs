namespace System.Diagnostics.Tracing
{
	/// <summary>Defines the tasks that apply to events.</summary>
	public enum EventTask
	{
		/// <summary>Undefined task.</summary>
		None
	}
}
namespace System.Collections.Concurrent
{
	[StructLayout(LayoutKind.Explicit, Size = 384)]
	[DebuggerDisplay("Head = {Head}, Tail = {Tail}")]
	internal struct PaddedHeadAndTail
	{
		[FieldOffset(128)]
		public int Head;

		[FieldOffset(256)]
		public int Tail;
	}
}
