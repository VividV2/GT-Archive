using System.Collections;
using System.Runtime.CompilerServices;

namespace System.Runtime.InteropServices
{
}
namespace System
{
	internal interface IValueTupleInternal : ITuple
	{
		int GetHashCode(IEqualityComparer comparer);

		string ToStringEnd();
	}
}
