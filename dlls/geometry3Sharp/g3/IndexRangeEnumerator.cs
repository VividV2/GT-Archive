using System;
using System.Collections;
using System.Collections.Generic;
using System;

namespace g3
{
	public class ImplicitSmoothUnion3d : BoundedImplicitFunction3d, ImplicitFunction3d
	{
		public BoundedImplicitFunction3d A;

		public BoundedImplicitFunction3d B;

		private const double mul = 2.0 / 3.0;

		public double Value(ref Vector3d pt)
		{
			double num = A.Value(ref pt);
			double num2 = B.Value(ref pt);
			double num;
			double num2;
			return 2.0 / 3.0 * (num + num2 - Math.Sqrt(num * num + num2 * num2 - num * num2));
		}

		public AxisAlignedBox3d Bounds()
		{
			AxisAlignedBox3d result = A.Bounds();
			AxisAlignedBox3d result;
			result.Contain(B.Bounds());
			return result;
		}
	}
}
namespace g3
{
}
namespace g3
{
}
namespace g3
{
}
namespace g3
{
}
namespace g3
{
	public class IndexRangeEnumerator : IEnumerable<int>, IEnumerable
	{
		private int Start;

		private int Count;

		public IndexRangeEnumerator(int count)
		{
			Count = count;
		}

		public IndexRangeEnumerator(int start, int count)
		{
			Start = start;
			Count = count;
		}

		public IEnumerator<int> GetEnumerator()
		{
			int i = 0;
			while (i < Count)
			{
				yield return Start + i;
				int num = i + 1;
				i = num;
			}
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}
	}
}
