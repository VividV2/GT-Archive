namespace Pathfinding.ClipperLib;

internal class OutRec
{
	public int Idx;

	public bool IsHole;

	public bool IsOpen;

	public OutRec FirstLeft;

	public OutPt Pts;

	public OutPt BottomPt;

	public PolyNode PolyNode;
}
namespace Pathfinding.ClipperLib
{
	public struct IntRect
	{
		public long left;

		public long top;

		public long right;

		public long bottom;

		public IntRect(long l, long t, long r, long b)
		{
			left = l;
			top = t;
			right = r;
			bottom = b;
		}

		public IntRect(IntRect ir)
		{
			left = ir.left;
			top = ir.top;
			right = ir.right;
			bottom = ir.bottom;
		}
	}
}
